# This script will export USPS credentials for all child accounts to a CSV file

from typing import List

import easypost
import argparse
import csv

parser = argparse.ArgumentParser(description='Export all child account USPS production credentials')
parser.add_argument('-k', '--key', required=True, help='Parent production API key')


def authenticate(key: str):
    """
    Authenticate with the given API key

    :param key: API key to authenticate with
    :type key: str
    :return: None
    """
    easypost.api_key = key


def get_production_key(keys: List) -> str:
    """
    Get the production key from a list of keys

    :param keys: List of keys
    :type keys: List
    :return: Production key
    :rtype: str
    """
    for key in keys:
        if key['mode'] == 'production':
            return key['key']


def process_child(child: easypost.User) -> dict:
    """
    Process a child account

    :param child: Child account object
    :type child: easypost.User
    :return: Dictionary of child account information
    :rtype: dict
    """
    child_prod_key = get_production_key(child.keys)
    authenticate(child_prod_key)
    accounts = get_usps_accounts()
    credentials = []
    for account in accounts:
        if account:
            account_details = get_usps_account_details(account)
            if account_details.get('test'):
                details = {**account_details.get('test'), 'ca_id': account.id, 'credential_type': 'test'}
                credentials.append(details)
            if account_details.get('prod'):
                details = {**account_details.get('prod'), 'ca_id': account.id, 'credential_type': 'prod'}
                credentials.append(details)
    return {
        'id': child.id,
        'accounts': credentials
    }


def get_usps_accounts() -> List[easypost.CarrierAccount]:
    """
    Get all USPS accounts for the current user

    :return: List of USPS accounts
    :rtype: List[easypost.CarrierAccount]
    """
    accounts = easypost.CarrierAccount.all()
    usps_accounts = []
    for account in accounts:
        if account.type == 'UspsAccount':
            usps_accounts.append(account)
    return usps_accounts


def get_usps_account_details(account: easypost.CarrierAccount) -> dict:
    """
    Get the credentials of a USPS account

    :param account: Carrier account object to get credentials for
    :type account: easypost.CarrierAccount
    :return: Dictionary of credentials
    :rtype: dict
    """
    return {
        'test': account.test_credentials,
        'prod': account.credentials,
    }


def write_to_csv(data: List[dict]):
    """
    Write the data to a CSV file

    :param data: Child account data
    :type data: List[dict]
    :return: None
    """
    with open('child_accounts.csv', 'w') as csvfile:
        fieldnames = ['child_id', 'ca_id', 'credential_type', 'city', 'state', 'street', 'zip', 'company', 'email',
                      'phone', 'shipper_id']
        writer = csv.DictWriter(csvfile, fieldnames=fieldnames)
        writer.writeheader()
        for child in data:
            for credential in child['accounts']:
                write_entry_to_csv(credential, child['id'], writer)


def write_entry_to_csv(credential: dict, child_id: str, writer: csv.DictWriter):
    """
    Write a single entry to the CSV file

    :param credential: Dictionary of credential information
    :type credential: dict
    :param child_id: ID of the child account
    :type child_id: str
    :param writer: CSV writer object
    :type writer: csv.DictWriter
    :return: None
    """
    writer.writerow({
        'child_id': child_id,
        'ca_id': credential.get('ca_id'),
        'credential_type': credential.get('credential_type'),
        'city': credential.get('address_city'),
        'state': credential.get('address_state'),
        'street': credential.get('address_street'),
        'zip': credential.get('address_zip'),
        'company': credential.get('company_name'),
        'email': credential.get('email'),
        'phone': credential.get('phone'),
        'shipper_id': credential.get('shipper_id'),
    })


def main():
    """
    Main function

    :return: None
    """
    args = parser.parse_args()
    easypost.api_key = args.key
    user = easypost.User.retrieve_me()
    children = user.all_api_keys().children
    data = []
    for child in children:
        child_info = process_child(child)
        data.append(child_info)
    write_to_csv(data)


if __name__ == '__main__':
    main()
