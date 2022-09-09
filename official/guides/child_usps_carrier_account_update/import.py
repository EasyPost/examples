# This script will import and update USPS credentials for all child accounts from a CSV file

# NOTE: Due to the nature of the easypost API library,
# this script will run synchronously and therefore may take a while to complete if you have a lot of child accounts

import argparse
import csv
from typing import (
    Any,
    Dict,
    List,
    Union,
)

import easypost


INPUT_FILE_NAME = "child_accounts.csv"

parser = argparse.ArgumentParser(description="Import all child account USPS production credentials")
parser.add_argument("-k", "--key", required=True, help="Parent production API key")
parser.add_argument("-f", "--file", required=False, help="File to read input from", default=INPUT_FILE_NAME)

OPTIONAL_FIELDS = ["shipper_id", "street2"]
ONE_OR_OTHER_FIELDS_1 = ["name", "company"]


def authenticate(key: str):
    """
    Authenticate with the given API key

    :param key: API key to authenticate with
    :type key: str
    :raises ValueError: If the key is invalid
    :return: None
    """
    if not key:
        raise ValueError("API key not provided")
    easypost.api_key = key


def get_production_key(keys: List[Dict[str, Any]]) -> Union[str, None]:
    """
    Get the production key from a list of keys

    :param keys: List of keys
    :type keys: List[Dict[str, Any]]
    :return: Production key if found, None otherwise
    :rtype: str | None
    """
    for key in keys:
        if key["mode"] == "production":
            return key["key"]
    return None


def process_entry(entry: Dict[str, Any], child: easypost.User):
    """
    Process a single entry from the CSV file

    :param entry: Entry from the CSV file
    :type entry: Dict[str, Any]
    :param child: Child account object
    :type child: easypost.User
    :return: None
    """
    child_prod_key: str = get_production_key(keys=child.keys)
    authenticate(key=child_prod_key)

    print(f"Updating credentials for child user {child.id}, carrier account {entry['carrier_account_id']}...")

    account: easypost.CarrierAccount = easypost.CarrierAccount.retrieve(easypost_id=entry["carrier_account_id"])
    if not account:
        print(f"Matching account not found for ID {entry['carrier_account_id']}. Skipping...")
        return

    account.credentials = entry["credentials"]

    try:
        account.save()
        print(f"Successfully updated credentials for carrier account {entry['carrier_account_id']}\n")
    except easypost.Error as e:
        print(f"Error updating credentials for carrier account {entry['carrier_account_id']}: {e}")


def read_from_csv() -> List[Dict[str, Any]]:
    """
    Read and validate data from the CSV file

    :return: List of valid entries from the CSV file
    :rtype: List[Dict[str, Any]]
    """
    print(f"Reading records from {INPUT_FILE_NAME}...")

    with open(INPUT_FILE_NAME, "r") as csvfile:
        reader = csv.DictReader(csvfile)
        data: List[Dict[str, Any]] = []
        for row in reader:
            entry: Dict[str, Any] = {
                "child_id": row["child_id"],
                "carrier_account_id": row["carrier_account_id"],
                "credential_type": row["credential_type"],
                "credentials": {
                    "address_city": row["city"],
                    "address_state": row["state"],
                    "address_street": row["street"],
                    "address_zip": row["zip"],
                    "company_name": row["company"],
                    "email": row["email"],
                    "phone": row["phone"],
                    "shipper_id": row["shipper_id"],
                },
            }
            if validate_entry(row=entry):
                data.append(entry)
        return data


def any_field_exists(data: Dict[str, Any], fields: List[str]) -> bool:
    """
    Check if at least one of the indicated fields has a value

    :param data: Data to parse
    :type data: Dict[str, Any]
    :param fields: List of fields to search for
    :type fields: List[str]
    :return: True if at least one field has a value, False otherwise
    :rtype: bool
    """
    return any([data.get(key, None) for key in fields])


def validate_entry(row: Dict[str, Any]) -> bool:
    """
    Validate a row entry from the CSV file

    :param row: Data from the CSV file
    :type row: Dict[str, Any]
    :raises Exception: If the entry is invalid
    :return: True if the row is valid, False otherwise
    :rtype: bool
    """
    print(f"Validating entry for carrier account ID {row['carrier_account_id']}...")

    valid: bool = True
    for k, v in row["credentials"].items():
        if k in OPTIONAL_FIELDS:  # These are optional fields that can be empty
            continue
        if not any_field_exists(data=row["credentials"], fields=ONE_OR_OTHER_FIELDS_1):
            # name or company must be present
            print(f'Missing required name or company for carrier account {row["carrier_account_id"]}')
            valid = False
        if k not in ONE_OR_OTHER_FIELDS_1 and (not v or v == ""):
            # Warning, doesn't halt execution
            # Mild confusion, this will print out the expected key,
            # not the key from the CSV file (e.g. 'address_city' instead of 'city')
            print(f'Missing required field "{k}" for carrier account {row["carrier_account_id"]}')
            valid = False
    if not valid:
        print(f"Skipping entry for carrier account {row['carrier_account_id']}\n")
    return valid


def main():
    """
    Main function

    :return: None
    """
    args = parser.parse_args()
    authenticate(key=args.key)

    user: easypost.User = easypost.User.retrieve_me()
    all_children: List[easypost.User] = user.all_api_keys().children

    print(f"Retrieved {len(all_children)} child accounts from API...")

    csv_data: List[Dict[str, Any]] = read_from_csv()

    count = 1
    total = len(csv_data)
    print(f"Retrieved {total} entries from CSV file...")

    for entry in csv_data:
        print(f"Processing entry {count}/{total}...")

        # noinspection PyTypeChecker
        matching_child: easypost.User = None
        print("Locating matching child account...")
        for child in all_children:
            if child.id == entry["child_id"]:
                matching_child: easypost.User = child
                break
        if not matching_child:
            # Warning, doesn't halt execution
            print(f"Matching child account not found for ID {entry['child_id']}. Skipping...")
            continue
        process_entry(entry=entry, child=matching_child)
        count += 1


if __name__ == "__main__":
    main()
