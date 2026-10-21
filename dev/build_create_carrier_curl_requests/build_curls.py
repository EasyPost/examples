import copy
import json
import os
import re
import shutil

import carrier_builder_data
import carrier_builder_payloads
import easypost

# Builds a file containing every create a Carrier Account cURL request via EasyPost
# USAGE: EASYPOST_PROD_API_KEY=123... venv/bin/python build_curls.py

API_KEY = os.getenv("EASYPOST_PROD_API_KEY")
LINE_BREAK_CHARS = " \\\n"
END_CHARS = "\n"
CUSTOM_WORKFLOW_CHARS = "## REQUIRES CUSTOM WORKFLOW ##\n"
OUTPUT_DESTINATION = os.path.join("..", "..", "carriers", "create-curls")


def reset_output_directory() -> None:
    """Delete and recreate the output directory so every run is fully regenerated."""
    if os.path.exists(OUTPUT_DESTINATION):
        shutil.rmtree(OUTPUT_DESTINATION)

    os.makedirs(OUTPUT_DESTINATION)


def main():
    reset_output_directory()
    carrier_types = get_carrier_types()
    for carrier in sorted(carrier_types, key=lambda x: x["type"]):
        curl_request = build_carrier_curl_request(carrier)
        with open(
            os.path.join(OUTPUT_DESTINATION, f"{carrier['type'].lower().replace('account', '')}.sh"),
            "w",
        ) as carrier_curl_file:
            carrier_curl_file.write(re.sub(r"^.*?\n", "", curl_request))


def get_carrier_types():
    """Get the carrier_types from the EasyPost API."""
    client = easypost.EasyPostClient(API_KEY)
    carrier_accounts = client.carrier_account.types()

    existing_types = {carrier["type"] for carrier in carrier_accounts}
    for static_carrier_type in carrier_builder_data.STATIC_CARRIER_TYPES:
        if static_carrier_type not in existing_types:
            carrier_accounts.append({"type": static_carrier_type})

    return carrier_accounts


def build_carrier_curl_request(carrier):
    """Builds a single cURL request for a carrier via EasyPost."""
    carrier_output = f"# {carrier.get('type')}\n"
    carrier_output = add_curl_line(carrier_output, carrier)
    carrier_output = add_headers(carrier_output, carrier)
    carrier_output = add_credential_structure(carrier_output, carrier)

    return carrier_output


def add_curl_line(carrier_output: str, carrier: dict[str, str]) -> str:
    """Add curl command and registration url."""
    endpoint = get_create_endpoint(carrier["type"])
    carrier_output += f"curl -X POST https://api.easypost.com/{endpoint}{LINE_BREAK_CHARS}"

    return carrier_output


def get_create_endpoint(carrier_type: str) -> str:
    """Resolve create endpoint for a carrier account type."""
    for endpoint, carrier_types in carrier_builder_data.CARRIER_CREATE_ENDPOINT_OVERRIDES.items():
        if carrier_type in carrier_types:
            return endpoint

    return carrier_builder_data.DEFAULT_CREATE_ENDPOINT


def add_headers(carrier_output: str, carrier: dict[str, str]) -> str:
    """Add necessry headers and authentication."""
    carrier_output += f'  -u "$EASYPOST_API_KEY":{LINE_BREAK_CHARS}'
    carrier_output += f"  -H 'Content-Type: application/json'{LINE_BREAK_CHARS}"

    return carrier_output


def is_wallet_carrier_type(carrier_type: str) -> bool:
    """Wallet-only carriers are defined explicitly in carrier builder data."""
    return carrier_type in carrier_builder_data.WALLET_ONLY_CARRIER_TYPES


def write_wallet_curl(
    carrier: dict[str, str],
    carrier_account_json: dict,
    endpoint: str | None = None,
) -> None:
    """Create a Wallet cURL for carriers that support EasyPost BYOCA and Wallet."""
    wallet_json = copy.deepcopy(carrier_account_json)
    wallet_payload_key = "carrier_account"
    if wallet_payload_key not in wallet_json:
        wallet_payload_key = "carrier_account_oauth_registrations"

    wallet_account = wallet_json[wallet_payload_key]
    wallet_account.pop("credentials", None)
    wallet_account.pop("test_credentials", None)
    # One key BYOCA vs wallet difference is billing: wallet carriers are
    # billed via EasyPost, so set payment_mode to aggregation.
    wallet_account["payment_mode"] = "aggregation"
    wallet_output = f"# {carrier.get('type')} (EasyPost Wallet)\n"
    wallet_endpoint = endpoint or get_create_endpoint(carrier["type"])
    wallet_output += f"curl -X POST https://api.easypost.com/{wallet_endpoint}{LINE_BREAK_CHARS}"
    wallet_output = add_headers(wallet_output, carrier)
    wallet_output += f"  -d '{json.dumps(wallet_json, indent=2)}'"
    wallet_output += END_CHARS
    wallet_output = wallet_output.replace(
        f"{LINE_BREAK_CHARS}{END_CHARS}",
        END_CHARS,
    )
    carrier_filename = carrier["type"].lower().replace("account", "")
    with open(
        os.path.join(OUTPUT_DESTINATION, f"{carrier_filename}wallet.sh"),
        "w",
    ) as wallet_file:
        wallet_file.write(re.sub(r"^.*?\n", "", wallet_output))


def add_credential_structure(carrier_output: str, carrier: dict[str, str]) -> str:
    """Iterate over the carrier fields and print the credential structure."""
    wallet_variant_payload: dict | None = None
    wallet_variant_endpoint: str | None = None

    if carrier["type"] == "UpsDapAccount":
        carrier_account_json = carrier_builder_payloads.ups_dap_account_payload()
        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
        return carrier_output

    if carrier["type"] == "FedexDefaultAccount":
        carrier_account_json = carrier_builder_payloads.fedex_default_account_payload()
        if is_wallet_carrier_type(carrier["type"]):
            carrier_account_json["carrier_account"]["payment_mode"] = "aggregation"
        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
        return carrier_output

    carrier_account_json = {
        "carrier_account": {
            "type": carrier["type"],
            "description": carrier["type"],
        }
    }

    carrier_fields = carrier.get("fields").to_dict()
    # FedEx
    if carrier["type"] in carrier_builder_data.FEDEX_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json["carrier_account"]["registration_data"] = {}
        for category in carrier_fields["creation_fields"]:
            for item in carrier_fields["creation_fields"][category]:
                carrier_account_json["carrier_account"]["registration_data"][item] = "VALUE"
        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
        carrier_output = carrier_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")
    # Maersk Parcel — custom static credential structure
    elif carrier["type"] in carrier_builder_data.MAERSK_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json = carrier_builder_payloads.maersk_account_payload()
        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
        carrier_output = carrier_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")
        return carrier_output
    # UPS OAuth
    elif carrier["type"] == "UpsAccount":
        carrier_account_json = carrier_builder_payloads.ups_oauth_registration_payload()
        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS

        # UPS wallet follows the same OAuth registration payload and endpoint
        # pattern as BYOCA, with payment_mode set for wallet billing.
        wallet_variant_payload = carrier_account_json
        wallet_variant_endpoint = get_create_endpoint(carrier["type"])
    # Amazon Shipping
    elif carrier["type"] in carrier_builder_data.OAUTH_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json = carrier_builder_payloads.amazon_shipping_oauth_registration_payload()
        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
    # DoorDash
    elif carrier["type"] in carrier_builder_data.DOORDASH_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json = carrier_builder_payloads.doordash_account_payload()
        carrier_output = (
            "# DoorDashAccount\n"
            "curl -XPOST "
            "-H 'Content-Type: application/json' "
            "-H 'X-EasyPost-User-Id: <user-id>' "
            "https://api.easypost.com/v2/carrier_accounts "
            "-d '" + json.dumps(carrier_account_json, indent=2) + "'" + END_CHARS
        )
        return carrier_output
    # Normal carriers
    else:
        end = END_CHARS

        # top_level here means `credentials`, `test_credentials`,
        # or `custom_workflow`
        for top_level in carrier_fields:
            # If there is a custom_workflow such as 3rd party auth
            # or a similar flow, warn about that here. The credential
            # structure will differ from a normal carrier account and is not automated.
            if top_level == "custom_workflow":
                end += CUSTOM_WORKFLOW_CHARS
            else:
                top_level_carrier_fields = carrier_fields[top_level]

                for item in top_level_carrier_fields:
                    if carrier_account_json["carrier_account"].get(top_level) is None:
                        carrier_account_json["carrier_account"][top_level] = {}

                    carrier_account_json["carrier_account"][top_level][item] = "VALUE"

        # Wallet-only carrier types should always explicitly use aggregation.
        if is_wallet_carrier_type(carrier["type"]):
            carrier_account_json["carrier_account"]["payment_mode"] = "aggregation"

        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += end
        carrier_output = carrier_output.replace(
            f"{LINE_BREAK_CHARS}{END_CHARS}",
            END_CHARS,
        )

        if carrier["type"] in carrier_builder_data.BYOCA_AND_WALLET_CARRIER_TYPES:
            wallet_variant_payload = carrier_account_json

    if wallet_variant_payload is not None:
        write_wallet_curl(
            carrier,
            wallet_variant_payload,
            endpoint=wallet_variant_endpoint,
        )

    return carrier_output


if __name__ == "__main__":
    main()
