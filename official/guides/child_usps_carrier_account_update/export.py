# This script will export USPS credentials for all child accounts to a CSV file

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


OUTPUT_FILE_NAME = "child_accounts.csv"

parser = argparse.ArgumentParser(description="Export all child account USPS production credentials")
parser.add_argument("-k", "--key", required=True, help="Parent production API key")
parser.add_argument("-f", "--file", required=False, help="File to write output to", default=OUTPUT_FILE_NAME)


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


def process_child(child: easypost.User) -> Dict[str, Any]:
    """
    Process a child account

    :param child: Child account object
    :type child: easypost.User
    :return: Dictionary of child account information
    :rtype: Dict
    """
    child_prod_key: str = get_production_key(keys=child.keys)
    authenticate(key=child_prod_key)

    usps_accounts: List[easypost.CarrierAccount] = get_usps_accounts()

    print(f"Processing {len(usps_accounts)} USPS accounts for child {child.id}...")

    credentials: List[Dict[str, Any]] = []
    for usps_account in usps_accounts:
        details: Dict[str, Any] = {
            **usps_account.credentials.to_dict(),
            "carrier_account_id": usps_account.id,
            "credential_type": "prod",
        }
        credentials.append(details)

    return {
        "id": child.id,
        "usps_accounts": credentials,
    }


def get_usps_accounts() -> List[easypost.CarrierAccount]:
    """
    Get all USPS accounts for the current user

    :return: List of USPS accounts
    :rtype: List[easypost.CarrierAccount]
    """
    all_accounts: List[easypost.CarrierAccount] = easypost.CarrierAccount.all()

    usps_accounts: List[easypost.CarrierAccount] = []
    for account in all_accounts:
        if account.type == "UspsAccount":
            usps_accounts.append(account)

    return usps_accounts


def write_to_csv(data: List[Dict[str, Any]]):
    """
    Write the data to a CSV file

    :param data: Child account data
    :type data: List[Dict[str, Any]]
    :return: None
    """
    print(f"Writing records to {OUTPUT_FILE_NAME}...")

    count = 0
    with open(OUTPUT_FILE_NAME, "w") as csv_file:
        fieldnames = [
            "child_id",
            "carrier_account_id",
            "credential_type",
            "city",
            "state",
            "street",
            "zip",
            "company_or_name",
            "email",
            "phone",
            "shipper_id",
        ]
        writer = csv.DictWriter(f=csv_file, fieldnames=fieldnames)
        writer.writeheader()
        rows = []
        for child in data:
            for usps_account in child["usps_accounts"]:
                row: Dict[str, Any] = {
                    "child_id": child.get("id", ""),
                    "carrier_account_id": usps_account.get("carrier_account_id", ""),
                    "credential_type": usps_account.get("credential_type", ""),
                    "city": usps_account.get("address_city", ""),
                    "state": usps_account.get("address_state", ""),
                    "street": usps_account.get("address_street", ""),
                    "zip": usps_account.get("address_zip", ""),
                    "company_or_name": usps_account.get("company_name", ""),
                    "email": usps_account.get("email", ""),
                    "phone": usps_account.get("phone", ""),
                    "shipper_id": usps_account.get("shipper_id", ""),
                }
                rows.append(row)
                count += 1
        writer.writerows(rows)

    print(f"Successfully wrote {count} records to {OUTPUT_FILE_NAME}...")


def main():
    """
    Main function

    :return: None
    """
    args = parser.parse_args()
    authenticate(key=args.key)

    user: easypost.User = easypost.User.retrieve_me()
    children: List[easypost.User] = user.all_api_keys().children

    count = 1
    total = len(children)

    data: List[Dict[str, Any]] = []
    for child in children:
        print(f"Processing child {count}/{total}...")
        child_info: Dict[str, Any] = process_child(child=child)
        data.append(child_info)
        count += 1

    write_to_csv(data=data)
    print("Export complete.")


if __name__ == "__main__":
    main()
