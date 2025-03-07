import json
import os
from typing import (
    Any,
    Dict,
    List,
    Tuple,
)

import easypost
import pytest
from dotenv import load_dotenv

load_dotenv()


EASYPOST_TEST_API_KEY = os.getenv("EASYPOST_TEST_API_KEY")
EASYPOST_PROD_API_KEY = os.getenv("EASYPOST_PROD_API_KEY")
PARTNER_USER_PROD_API_KEY = os.getenv("PARTNER_USER_PROD_API_KEY", "123")

OVERWRITE = "all" if os.getenv("OVERWRITE", False) else "once"

SCRUBBED_STRING = "<REDACTED>"
SCRUBBED_ARRAY: List = []
SCRUBBED_DICT: Dict = {}


@pytest.fixture(autouse=True)
def setup_api_key():
    """This fixture is auto-loaded by all tests; it sets up the api key."""
    default_key = easypost.api_key
    easypost.api_key = EASYPOST_TEST_API_KEY
    yield
    easypost.api_key = default_key


@pytest.fixture
def prod_api_key():
    """If a test needs to use the prod api key, make it depend on this fixture."""
    default_key = easypost.api_key
    easypost.api_key = EASYPOST_PROD_API_KEY
    yield
    easypost.api_key = default_key


@pytest.fixture
def partner_prod_api_key():
    """If a test needs to use the partner prod api key, make it depend on this fixture."""
    default_key = easypost.api_key
    easypost.api_key = PARTNER_USER_PROD_API_KEY
    yield
    easypost.api_key = default_key


@pytest.fixture(scope="session")
def vcr_config():
    """Setup the VCR config for the test suite."""
    return {
        "match_on": [
            "body",
            "method",
            "query",
            "uri",
        ],
        "record_mode": OVERWRITE,
        "decode_compressed_response": True,
        "filter_headers": [
            ("authorization", SCRUBBED_STRING),
            ("user-agent", SCRUBBED_STRING),
        ],
        "filter_query_parameters": [
            "card[number]",
            "card[cvc]",
        ],
        "before_record_response": scrub_response_bodies(
            scrubbers=[
                ["client_ip", SCRUBBED_STRING],
                ["key", SCRUBBED_STRING],
            ]
        ),
    }


def scrub_response_bodies(scrubbers: List[Tuple[str, Any]]) -> Any:
    """Scrub sensitive data from response bodies prior to recording the cassette."""

    def before_record_response(response: Any) -> Any:
        """This function fires prior to persisting data to a cassette."""
        if response["body"]["string"]:
            response_body = json.loads(response["body"]["string"].decode())

            for scrubber in scrubbers:
                response_body = scrub_data(response_body, scrubber)

            response["body"]["string"] = json.dumps(response_body).encode()
        return response

    def scrub_data(data: Any, scrubber: Tuple[str, Any]) -> Any:
        """Scrub data from a cassette recursively."""
        key = scrubber[0]
        replacement = scrubber[1]

        # Root-level list scrubbing
        if isinstance(data, list):
            for index, item in enumerate(data):
                if key in item:
                    data[index][key] = replacement
        elif isinstance(data, dict):
            # Root-level key scrubbing
            if key in data:
                data[key] = replacement
            else:
                # Nested scrubbing
                for item in data:
                    element = data[item]
                    if isinstance(element, list):
                        for nested_index, nested_item in enumerate(element):
                            data[item][nested_index] = scrub_data(nested_item, scrubber)
                    elif isinstance(element, dict):
                        data[item] = scrub_data(element, scrubber)
        return data

    return before_record_response


def read_fixture_data():
    """Reads fixture data from the fixtures JSON file."""
    with open(os.path.join("..", "..", "..", "..", "official", "fixtures", "example-snippet-fixtures.json")) as data:
        fixtures = json.load(data)

    return fixtures


@pytest.fixture
def page_size():
    """We keep the page_size of retrieving `all` records small so cassettes stay small."""
    return 1


@pytest.fixture
def usps_carrier_account_id():
    """This is the USPS carrier account ID that comes with your
    EasyPost account by default and should be used for all tests.
    """
    # Fallback to the EasyPost Docs Tooling User USPS carrier account ID due to strict matching
    return os.getenv("USPS_CARRIER_ACCOUNT_ID", "ca_9685a1198a75477885a3cdca37559bac")


@pytest.fixture
def report_type():
    return "shipment"


@pytest.fixture
def report_date():
    return "2022-10-01"


@pytest.fixture
def address_create():
    return read_fixture_data()["address"]["create"]


@pytest.fixture
def address_create_and_verify():
    return read_fixture_data()["address"]["create_and_verify"]


@pytest.fixture
def address_create_strictly_verified():
    return read_fixture_data()["address"]["create_strictly_verified"]


@pytest.fixture
def carrier_account_create():
    return read_fixture_data()["carrier_account"]["create"]


@pytest.fixture
def customs_info_create():
    return read_fixture_data()["customs_info"]["create"]


@pytest.fixture
def customs_item_create():
    return read_fixture_data()["customs_item"]["create"]


@pytest.fixture
def end_shipper_create():
    return read_fixture_data()["end_shipper"]["create"]


@pytest.fixture
def form_create():
    return read_fixture_data()["form"]["create"]


@pytest.fixture
def insurance_create():
    return read_fixture_data()["insurance"]["create"]


@pytest.fixture
def order_create():
    return read_fixture_data()["order"]["create"]


@pytest.fixture
def parcel_create():
    return read_fixture_data()["parcel"]["create"]


@pytest.fixture
def pickup_create():
    """This fixture will require you to add a `shipment` key with a Shipment object from a test.
    If you need to re-record cassettes, increment the date below and ensure it is one day in the future,
    USPS only does "next-day" pickups including Saturday but not Sunday or Holidays.
    """
    pickup_date = "2022-10-29"

    pickup_data = read_fixture_data()["pickup"]["create"]
    pickup_data["min_datetime"] = pickup_date
    pickup_data["max_datetime"] = pickup_date

    return pickup_data


@pytest.fixture
def shipment_create():
    return read_fixture_data()["shipment"]["create"]


@pytest.fixture
def shipment_one_call_buy(usps_carrier_account_id):
    shipment_data = read_fixture_data()["shipment"]["create"]
    shipment_data["service"] = "Priority"
    shipment_data["carrier"] = "USPS"
    shipment_data["carrier_accounts"] = [usps_carrier_account_id]

    return shipment_data


@pytest.fixture
def tax_identifier_create():
    return read_fixture_data()["tax_identifier"]["create"]


@pytest.fixture
def tracker_create():
    return read_fixture_data()["tracker"]["create"]


@pytest.fixture
def webhook_create():
    return read_fixture_data()["webhook"]["create"]
