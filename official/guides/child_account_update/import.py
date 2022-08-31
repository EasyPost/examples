# This script will import and update USPS credentials for all child accounts from a CSV file

from typing import List

import easypost
import argparse
import csv

parser = argparse.ArgumentParser(description='Import all child account USPS production credentials')
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


def process_entry(entry: dict, child: easypost.User):
    """
    Process a single entry from the CSV file

    :param entry: Entry from the CSV file
    :type entry: dict
    :param child: Child account object
    :type child: easypost.User
    :return: None
    """
    child_prod_key = get_production_key(child.keys)
    authenticate(child_prod_key)

    account: easypost.CarrierAccount = easypost.CarrierAccount.retrieve(easypost_id=entry['ca_id'])
    if not account:
        print('Matching account not found for ID {}'.format(entry['ca_id']))
        return

    if entry['credential_type'] == 'test':
        account.test_credentials = entry['credentials']
    elif entry['credential_type'] == 'prod':
        account.prod_credentials = entry['credentials']
    print(account)
    # account.save()  # TODO: Uncomment this line to actually save the changes


def read_from_csv() -> List[dict]:
    """
    Read the CSV file

    :return: List of entries from the CSV file
    :rtype: List[dict]
    """
    with open('child_accounts.csv', 'r') as csvfile:
        reader = csv.DictReader(csvfile)
        data = []
        for row in reader:
            row_data = read_entry_from_csv(row)
            if validate_row(row_data):
                data.append(row_data)
        return data


def validate_row(row: dict) -> bool:
    """
    Validate a row from the CSV file

    :param row: Data from the CSV file
    :type row: dict
    :return: True if the row is valid, False otherwise
    :rtype: bool
    """
    for k, v in row['credentials'].items():
        if k in ['shipper_id']:  # These are optional fields that can be empty
            continue
        if not v or v == '':
            raise Exception(f'Missing required field {k} for carrier account {row["ca_id"]}')
    return True


def read_entry_from_csv(row) -> dict:
    """
    Read a single entry from the CSV file

    :param row: Row from the CSV file
    :return: Dictionary of entry data
    :rtype: dict
    """
    return {'child_id': row['child_id'],
            'ca_id': row['ca_id'],
            'credential_type': row['credential_type'],
            'credentials': {
                'address_city': row['city'],
                'address_state': row['state'],
                'address_street': row['street'],
                'address_zip': row['zip'],
                'company_name': row['company'],
                'email': row['email'],
                'phone': row['phone'],
                'shipper_id': row['shipper_id'],
            }
            }


def main():
    """
    Main function

    :return: None
    """
    args = parser.parse_args()
    easypost.api_key = args.key
    user = easypost.User.retrieve_me()
    all_children: List[easypost.User] = user.all_api_keys().children
    csv_data = read_from_csv()
    for entry in csv_data:
        matching_child = None
        for child in all_children:
            if child.id == entry['child_id']:
                matching_child = child
                break
        if not matching_child:
            print('Matching child account not found for ID {}'.format(entry['child_id']))
            continue
        process_entry(entry, matching_child)


if __name__ == '__main__':
    main()
