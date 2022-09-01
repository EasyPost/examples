# This script will export USPS credentials for all child accounts to a CSV file

# NOTE: Due to the nature of the easypost API library,
# this script will run synchronously and therefore may take a while to complete if you have a lot of child accounts

from typing import List, Dict, Union

import easypost
import argparse
import csv

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


def get_production_key(keys: List) -> Union[str, None]:
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


def process_child(child: easypost.User) -> Dict:
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
    for account in accounts:
        account_details = {
            "test": account.test_credentials,
            "prod": account.credentials,
        }
        if account_details.get("test"):
            details = {**account_details.get("test"), "ca_id": account.id, "credential_type": "test"}
            credentials.append(details)
        if account_details.get("prod"):
            details = {**account_details.get("prod"), "ca_id": account.id, "credential_type": "prod"}
            credentials.append(details)

    return {"id": child.id, "accounts": credentials}


def get_usps_accounts() -> List[easypost.CarrierAccount]:
    """
    Get all USPS accounts for the current user

    :return: List of USPS accounts
    :rtype: List[easypost.CarrierAccount]
    """
    accounts = easypost.CarrierAccount.all()
    usps_accounts = []
    for account in accounts:
        if account.type == "UspsAccount":
            usps_accounts.append(account)
    return usps_accounts


def write_to_csv(data: List[Dict]):
    """
    Write the data to a CSV file

    :param data: Child account data
    :type data: List[Dict]
    :return: None
    """
    with open("child_accounts.csv", "w") as csvfile:
        fieldnames = [
            "child_id",
            "ca_id",
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
            for credential in child["accounts"]:
                row = {
                    "child_id": child.get('id', ''),
                    "ca_id": credential.get("ca_id", ""),
                    "credential_type": credential.get("credential_type", ""),
                    "city": credential.get("address_city", ""),
                    "state": credential.get("address_state", ""),
                    "street": credential.get("address_street", ""),
                    "zip": credential.get("address_zip", ""),
                    "company": credential.get("company_name", ""),
                    "email": credential.get("email", ""),
                    "phone": credential.get("phone", ""),
                    "shipper_id": credential.get("shipper_id", ""),
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
