import json
import os
import re

import easypost


# Builds a file containing every create a Carrier Account cURL request via EasyPost
# USAGE: EASYPOST_PROD_API_KEY=123... venv/bin/python build_curls.py

API_KEY = os.getenv("EASYPOST_PROD_API_KEY")
LINE_BREAK_CHARS = " \\\n"
END_CHARS = "\n"
CUSTOM_WORKFLOW_CHARS = "## REQUIRES CUSTOM WORKFLOW ##\n"

FEDEX_CUSTOM_WORKFLOW_CARRIERS = [
    "FedexAccount",
    "FedexSmartpostAccount",
]
UPS_CUSTOM_WORKFLOW_CARRIERS = [
    "UpsAccount",
    "UpsDapAccount",
]
CANADAPOST_CUSTOM_WORKFLOW_CARRIERS = [
    "CanadaPostAccount",
]
OAUTH_CUSTOM_WORKFLOW_CARRIERS = [
    "AmazonShippingAccount",
]
MAERSK_CUSTOM_WORKFLOW_CARRIERS = [
    "MaerskAccount"
]
DOORDASH_CUSTOM_WORKFLOW_CARRIERS = [
    "DoorDashAccount"
]

def main():
    carrier_types = get_carrier_types()
    for carrier in sorted(carrier_types, key=lambda x: x["type"]):
        curl_request = build_carrier_curl_request(carrier)
        output_destination = os.path.join("../", "../", "official", "guides", "create-carrier-curls")
        if not os.path.exists(output_destination):
            os.makedirs(output_destination)

        with open(
            os.path.join(output_destination, f'{carrier["type"].lower().replace("account", "")}.sh'),
            "w",
        ) as carrier_curl_file:
            carrier_curl_file.write(re.sub(r"^.*?\n", "", curl_request))


def get_carrier_types():
    """Get the carrier_types from the EasyPost API."""
    client = easypost.EasyPostClient(API_KEY)
    carrier_accounts = client.carrier_account.types()

    return carrier_accounts


def build_carrier_curl_request(carrier):
    """Builds a single cURL request for a carrier via EasyPost."""
    carrier_output = f'# {carrier.get("type")}\n'
    carrier_output = add_curl_line(carrier_output, carrier)
    carrier_output = add_headers(carrier_output, carrier)
    carrier_output = add_credential_structure(carrier_output, carrier)

    return carrier_output


def add_curl_line(carrier_output: str, carrier: dict[str, str]) -> str:
    """Add curl command and registration url."""
    if carrier["type"] in (FEDEX_CUSTOM_WORKFLOW_CARRIERS + UPS_CUSTOM_WORKFLOW_CARRIERS):
        carrier_output += f"curl -X POST https://api.easypost.com/v2/carrier_accounts/register{LINE_BREAK_CHARS}"
    elif carrier["type"] in OAUTH_CUSTOM_WORKFLOW_CARRIERS:
        carrier_output += f"curl -X POST https://api.easypost.com/v2/carrier_accounts/register_oauth{LINE_BREAK_CHARS}"
    else:
        carrier_output += f"curl -X POST https://api.easypost.com/v2/carrier_accounts{LINE_BREAK_CHARS}"

    return carrier_output


def add_headers(carrier_output: str, carrier: dict[str, str]) -> str:
    """Add necessry headers and authentication."""
    carrier_output += f'  -u "$EASYPOST_API_KEY":{LINE_BREAK_CHARS}'
    carrier_output += f"  -H 'Content-Type: application/json'{LINE_BREAK_CHARS}"

    return carrier_output


def add_credential_structure(carrier_output: str, carrier: dict[str, str]) -> str:
    """Iterate over the carrier fields and print the credential structure."""
    carrier_account_json = {
        "carrier_account": {
            "type": carrier["type"],
            "description": carrier["type"],
        }
    }

    carrier_fields = carrier.get("fields").to_dict()
    # FedEx
    if carrier["type"] in FEDEX_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json["carrier_account"]["registration_data"] = {}
        for category in carrier_fields["creation_fields"]:
            for item in carrier_fields["creation_fields"][category]:
                carrier_account_json["carrier_account"]["registration_data"][item] = "VALUE"

        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
        carrier_output = carrier_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")
    # CanadaPost
    elif carrier["type"] in CANADAPOST_CUSTOM_WORKFLOW_CARRIERS:
        # BYOA cURL
        end = END_CHARS
        for top_level in carrier_fields:
            if top_level == "custom_workflow":
                end += CUSTOM_WORKFLOW_CHARS
            else:
                top_level_carrier_fields = carrier_fields[top_level]
                for item in top_level_carrier_fields:
                    if carrier_account_json["carrier_account"].get(top_level) is None:
                        carrier_account_json["carrier_account"][top_level] = {}
                    carrier_account_json["carrier_account"][top_level][item] = "VALUE"

        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += end
        carrier_output = carrier_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")

        # Default (aggregation) cURL
        default_output = f'# {carrier.get("type")} (EasyPost Aggregation)\n'
        default_output = add_curl_line(default_output, carrier)
        default_output = add_headers(default_output, carrier)

        default_json = {
            "carrier_account": {
                "type": carrier["type"],
                "payment_mode": "aggregation"
            }
        }

        default_output += f"  -d '{json.dumps(default_json, indent=2)}'"
        default_output += END_CHARS
        default_output = default_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")

        output_destination = os.path.join("../", "../", "official", "guides", "create-carrier-curls")
        if not os.path.exists(output_destination):
            os.makedirs(output_destination)

        with open(
            os.path.join(output_destination, "canadapost-default.sh"),
            "w",
        ) as default_file:
            default_file.write(re.sub(r"^.*?\n", "", default_output))

        return carrier_output
    # Maersk Parcel — custom static credential structure
    elif carrier["type"] in MAERSK_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json = {
            "carrier_account": {
                "type": "MaerskAccount",
                "description": "Maersk Account",
                "reference": None,
                "credentials": {
                    "first_name": "VALUE",
                    "last_name": "VALUE",
                    "company_name": "VALUE",
                    "email": "VALUE",
                    "phone": "VALUE",
                    "daily_number_of_shipments": "VALUE",
                    "channel": "VALUE",
                    "accepted_terms": "true",
                    "serial_number": "VALUE",
                    "origin_address_line_1": "VALUE",
                    "origin_address_line_2": "VALUE",
                    "origin_postal_code": "VALUE",
                    "origin_city": "VALUE",
                    "origin_state": "VALUE",
                    "billing_address_line_1": "VALUE",
                    "billing_address_line_2": "VALUE",
                    "billing_postal_code": "VALUE",
                    "billing_city": "VALUE",
                    "billing_state": "VALUE"
                },
                "test_credentials": {}
            }
        }

        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
        carrier_output = carrier_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")
        return carrier_output
    # Amazon Shipping
    elif carrier["type"] in OAUTH_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json = {
            "carrier_account_oauth_registrations": {
                "type": carrier["type"],
                "description": "My Shipping Account (optional)",
                "reference": "Internal reference id (optional)"
            }
        }

        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += END_CHARS
    # DoorDash
    elif carrier["type"] in DOORDASH_CUSTOM_WORKFLOW_CARRIERS:
        carrier_account_json = {
            "billToEasyPost": False,
            "credentials": {
                "developer_id": "VALUE",
                "key_id": "VALUE",
                "signing_secret": "VALUE",
                "pickup_external_business_id": "VALUE"
            },
            "test_credentials": {},
            "type": "DoorDashAccount"
        }

        carrier_output = (
            "# DoorDashAccount\n"
            "curl -XPOST "
            "-H 'Content-Type: application/json' "
            "-H 'X-EasyPost-User-Id: <user-id>' "
            "https://api.easypost.com/v2/carrier_accounts "
            "-d '"
            + json.dumps(carrier_account_json, indent=2)
            + "'"
            + END_CHARS
        )
        return carrier_output
    # Normal carriers
    else:
        end = END_CHARS
        # top_level here means `credentials` or `test_credentials` or `custom_workflow`
        for top_level in carrier_fields:
            # TODO: If there is a custom_workflow such as 3rd party auth or a similar flow
            # we should warn about that here. The credential structure will differ from
            # a normal carrier account and is currently not automated
            if top_level == "custom_workflow":
                end += CUSTOM_WORKFLOW_CHARS
            else:
                top_level_carrier_fields = carrier_fields[top_level]
                for item in top_level_carrier_fields:
                    if carrier_account_json["carrier_account"].get(top_level) is None:
                        carrier_account_json["carrier_account"][top_level] = {}
                    carrier_account_json["carrier_account"][top_level][item] = "VALUE"

        carrier_output += f"  -d '{json.dumps(carrier_account_json, indent=2)}'"
        carrier_output += end
        carrier_output = carrier_output.replace(f"{LINE_BREAK_CHARS}{END_CHARS}", f"{END_CHARS}")

    return carrier_output

if __name__ == "__main__":
    main()
