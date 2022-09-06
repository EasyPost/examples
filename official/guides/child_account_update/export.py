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
    :type keys: List
    :return: Production key if found, None otherwise
    :rtype: str | None
    """
    for key in keys:
        if key["mode"] == "production":
            return key["key"]
    return None


def remap_credentials(credentials: 'EasyPostObject') -> Dict[str, Any]:
    """
    Remap a credentials dictionary to only necessary key-value pairs

    :param credentials: Credentials dictionary of a USPS account
    :type credentials: Dict[str, Any]
    :return: Remapped credentials dictionary
    :rtype: Dict[str, Any]
    """
    remapped = {}
    if not credentials:
        return remapped
    for key, value in credentials.to_dict().items():
        remapped[key] = value["value"]
    return remapped


def process_child(child: easypost.User) -> Dict[str, Any]:
    """
    Process a child account

    :param child: Child account object
    :type child: easypost.User
    :return: Dictionary of child account information
    :rtype: Dict
    """
    child_prod_key = get_production_key(child.keys)
    authenticate(child_prod_key)
    accounts = get_usps_accounts()
    credentials = []
    for usps_account in accounts:
        details = {
            **remap_credentials(usps_account["fields"].get("credentials")),
            "carrier_account_id": usps_account.id,
            "credential_type": "prod",
        }
        credentials.append(details)

    return {"id": child.id, "accounts": credentials}


def get_usps_accounts() -> List[easypost.CarrierAccount]:
    """
    Get all USPS accounts for the current user

    :return: List of USPS accounts
    :rtype: List[easypost.CarrierAccount]
    """
    all_accounts = easypost.CarrierAccount.all()
    usps_accounts = []
    for account in all_accounts:
        if account.type == "UspsAccount":
            usps_accounts.append(account)
    return usps_accounts


def write_to_csv(data: List[Dict[str, Any]]):
    """
    Write the data to a CSV file

    :param data: Child account data
    :type data: List[Dict]
    :return: None
    """
    with open(OUTPUT_FILE_NAME, "w") as csvfile:
        fieldnames = [
            "child_id",
            "carrier_account_id",
            "credential_type",
            "city",
            "state",
            "street",
            "zip",
            "company",
            "email",
            "phone",
            "shipper_id",
        ]
        writer = csv.DictWriter(csvfile, fieldnames=fieldnames)
        writer.writeheader()
        rows = []
        for child in data:
            for usps_account in child["accounts"]:
                row = {
                    "child_id": child.get("id", ""),
                    "carrier_account_id": usps_account.get("carrier_account_id", ""),
                    "credential_type": usps_account.get("credential_type", ""),
                    "city": usps_account.get("address_city", ""),
                    "state": usps_account.get("address_state", ""),
                    "street": usps_account.get("address_street", ""),
                    "zip": usps_account.get("address_zip", ""),
                    "company": usps_account.get("company_name", ""),
                    "email": usps_account.get("email", ""),
                    "phone": usps_account.get("phone", ""),
                    "shipper_id": usps_account.get("shipper_id", ""),
                }
                rows.append(row)
        writer.writerows(rows)


def main():
    """
    Main function

    :return: None
    """
    args = parser.parse_args()
    authenticate(args.key)

    user = easypost.User.retrieve_me()
    children = user.all_api_keys().children

    data = []
    for child in children:
        child_info = process_child(child)
        data.append(child_info)
    write_to_csv(data)


if __name__ == "__main__":
    main()
