import json
import os
from typing import (
    Any,
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
    "customer-portals",
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


def build_response_snippet(interaction_index: int | None = 0, objects_to_persist: int | None = None):
    """Builds the response snippet from a recorded VCR interaction."""
    create_dir(os.path.join(RESPONSES_DIR))

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    cassette_filename = f"{test_name}.yaml"

    cassette_content = extract_response_from_cassette(cassette_filename, interaction_index)

    response_snippet_folder, bare_snippet_name = save_response_snippet(
        cassette_filename, cassette_content, objects_to_persist
    )

    # Assert the standalone snippet actually got saved, fail if not
    assert os.path.exists(os.path.join(RESPONSES_DIR, response_snippet_folder, bare_snippet_name)), (
        f"{bare_snippet_name} standalone snippet file missing!"
    )


def create_dir(dir_name: str):
    """Creates a directory if it does not exist yet."""
    if not os.path.exists(dir_name):
        os.mkdir(dir_name)


def extract_response_from_cassette(cassette_filename: str, interaction_index: int | None = 0) -> Any:
    """Opens a single cassette file and extracts the response content."""
    cassette_file = os.path.join("tests", "cassettes", cassette_filename)
    if not os.path.exists(cassette_file):
        raise FileNotFoundError(f"{cassette_filename} not found, run the tests again.")

    with open(cassette_file, "r") as cassette:
        cassette_data = yaml.safe_load(cassette)
        for key in cassette_data:
            if key == "interactions":
                response_content = cassette_data[key][interaction_index]["response"]["body"]["string"]
                response = response_content if response_content else "{}"

    return response


def _setup_saving_response_snippet(response_snippet_filename: str):
    """Reusable helper to setup the logic to save a standalone response snippet."""

    normalized_name = response_snippet_filename.replace("test_", "").replace(".yaml", "")
    split_name = normalized_name.split("_")

    first_resource_name = split_name[0]
    second_resource_name = split_name[1] if len(split_name) > 1 else ""
    first_and_second_resource_name = f"{first_resource_name}-{second_resource_name}"

    # Some resources are two words and represented with hyphens in docs paths (eg: scan-form).
    if first_and_second_resource_name in ALL_RESOURCES:
        resource_name = first_and_second_resource_name
        action_start_index = 2
    else:
        resource_name = first_resource_name
        action_start_index = 1

    action_name = "-".join(split_name[action_start_index:])
    if not action_name:
        raise ValueError(f"Could not parse action name from: {response_snippet_filename}")

    # Response filenames should only contain the action name (no resource prefix).
    response_snippet_folder = resource_name.replace("_", "-")
    bare_snippet_name = f"{action_name.replace('_', '-')}.json"

    create_dir(os.path.join(RESPONSES_DIR, response_snippet_folder))

    return response_snippet_folder, bare_snippet_name


def save_response_snippet(
    response_snippet_filename: str,
    response_snippet_content: Any,
    objects_to_persist: int | None = None,
) -> tuple[str, str]:
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


def save_raw_json(response_snippet_filename: str, response_dict: dict[str, Any]):
    """Saves a raw response dictionary to a standalone snippet file (used for hard-coded responses
    that cannot easily be plugged into a test suite (eg: Billing functions).
    """
    response_snippet_folder, bare_snippet_name = _setup_saving_response_snippet(response_snippet_filename)

    with open(os.path.join(RESPONSES_DIR, response_snippet_folder, bare_snippet_name), "w") as response_snippet_file:
        json.dump(response_dict, response_snippet_file, indent=2)

        response_snippet_file.write("\n")
