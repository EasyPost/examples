import json
import os
from typing import (
    Any,
    Dict,
    Optional,
    Tuple,
)

import yaml


ALL_RESOURCES = {
    "addresses",
    "api-keys",
    "batches",
    "billing",
    "brand",
    "carrier-accounts",
    "carrier-metadata",
    "carrier-types",
    "child-users",
    "customs-infos",
    "customs-items",
    "endshipper",
    "events",
    "insurance",
    "luma",
    "options",
    "orders",
    "parcels",
    "pickups",
    "rates",
    "referral-customers",
    "refunds",
    "reports",
    "returns",
    "scan-form",
    "shipments",
    "shipping-insurance",
    "shipping-refund",
    "smartrate",
    "tax-identifiers",
    "trackers",
    "users",
    "webhooks",
}

RESPONSES_DIR = os.path.join("..", "..", "official", "docs", "responses")


def build_response_snippet(interaction_index: Optional[int] = 0, objects_to_persist: Optional[int] = None):
    """Builds the response snippet from a recorded VCR interaction."""
    create_dir(os.path.join(RESPONSES_DIR))

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    cassette_filename = f"{test_name}.yaml"

    cassette_content = extract_response_from_cassette(cassette_filename, interaction_index)

    response_snippet_folder, bare_snippet_name = save_response_snippet(
        cassette_filename, cassette_content, objects_to_persist
    )

    # Assert the standalone snippet actually got saved, fail if not
    assert os.path.exists(
        os.path.join(RESPONSES_DIR, response_snippet_folder, bare_snippet_name)
    ), f"{bare_snippet_name} standalone snippet file missing!"


def create_dir(dir_name: str):
    """Creates a directory if it does not exist yet."""
    if not os.path.exists(dir_name):
        os.mkdir(dir_name)


def extract_response_from_cassette(cassette_filename: str, interaction_index: Optional[int] = 0) -> Any:
    """Opens a single cassette file and extracts the response content."""
    cassette_file = os.path.join("tests", "cassettes", cassette_filename)
    if not os.path.exists(cassette_file):
        raise FileNotFoundError(f"{cassette_filename} not found, run the tests again.")

    with open(cassette_file, "r") as cassette:
        try:
            cassette_data = yaml.safe_load(cassette)
            for key, _ in cassette_data.items():
                if key == "interactions":
                    response_content = cassette_data[key][interaction_index]["response"]["body"]["string"]
                    response = response_content if response_content else "{}"
        except yaml.YAMLError:
            raise

    return response


def _setup_saving_response_snippet(response_snippet_filename: str):
    """Reusable helper to setup the logic to save a standalone response snippet."""

    bare_snippet_name = response_snippet_filename.replace("test_", "").replace(".yaml", ".json")
    split_resource_name = bare_snippet_name.split("_")
    first_resource_name = split_resource_name[0]
    second_resource_name = split_resource_name[1]
    first_and_second_resource_name = f"{first_resource_name}-{second_resource_name}"
    resource_name = (
        first_resource_name if first_and_second_resource_name not in ALL_RESOURCES else first_and_second_resource_name
    )

    # Setup the names like the website wants it
    response_snippet_folder = resource_name.replace("_", "-")
    bare_snippet_name = bare_snippet_name.replace("_", "-")

    create_dir(os.path.join(RESPONSES_DIR, response_snippet_folder))

    return response_snippet_folder, bare_snippet_name


def save_response_snippet(
    response_snippet_filename: str,
    response_snippet_content: Any,
    objects_to_persist: Optional[int] = None,
) -> Tuple[str, str]:
    """Saves the response content of a cassette to a standalone snippet file."""
    response_snippet_folder, bare_snippet_name = _setup_saving_response_snippet(response_snippet_filename)

    with open(os.path.join(RESPONSES_DIR, response_snippet_folder, bare_snippet_name), "w") as response_snippet_file:
        if objects_to_persist:
            json.dump(
                json.loads(response_snippet_content)[:objects_to_persist],
                response_snippet_file,
                indent=2,
            )
        else:
            json.dump(json.loads(response_snippet_content), response_snippet_file, indent=2)

        response_snippet_file.write("\n")

    return response_snippet_folder, bare_snippet_name


def save_raw_json(response_snippet_filename: str, response_dict: Dict[str, Any]):
    """Saves a raw response dictionary to a standalone snippet file (used for hard-coded responses
    that cannot easily be plugged into a test suite (eg: Billing functions).
    """
    response_snippet_folder, bare_snippet_name = _setup_saving_response_snippet(response_snippet_filename)

    bare_snippet_name = f"{bare_snippet_name}.json"

    with open(os.path.join(RESPONSES_DIR, response_snippet_folder, bare_snippet_name), "w") as response_snippet_file:
        json.dump(response_dict, response_snippet_file, indent=2)

        response_snippet_file.write("\n")
