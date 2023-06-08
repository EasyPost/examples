# Mass Update USPS Credentials for Child Users

These scripts are intended to provide easy-to-use functionality for retrieving and updating the UspsAccount carrier credentials for each Child User linked to a Parent account.

Accurate carrier account credentials will ensure the EndShipper information is properly passed to the USPS during postage buy requests. While there are many ways to retrieve and update carrier account credentials, we are providing a simple three-step process you can follow.

**Please note**, due to the EasyPost client library being non-thread-safe, these scripts may take a while to run if you have a large number of Child Users, due to API key switching.

## Setup

Before running the scripts, you will need to install the EasyPost Python client library and other dependencies. You can do this by running the following command:

`python3 -m pip install -r requirements.txt`

### Step 1: Run the `export.py` script

This script will export the UspsAccount credentials for every Child User linked to the parent. If there are multiple UspsAccounts for one Child, multiple rows will be returned.

It accomplishes this by:

- Using the parent accounts production API key, pulling all children and their API keys
- For each child user, it re-authenticates using the child-specific key
- For each child user, it pulls the linked carrier account details
- For each UspsAccount carrier account linked to that child, it will pull the account details, and store the UspsAccount credentials information in the CSV file

To run the script:

`python3 export.py -k <EASYPOST_PROD_API_KEY>`

The final output will be saved to a `child_account.csv` file with columns for child user public id, carrier account id, and the child-account credentials.

It is **highly recommended** for users with many child accounts to pipe the log output of this script to a file for easier viewing upon completion.

### Step 2: Update the `child_accounts.csv` file with accurate information

**Template:** If you cannot reliably export your data or you already have it stored elsewhere and only want to update it, you can fill in the template of the `child_accounts.csv` file found in this directory.

The credentials for each UspsAccount must reflect accurate and complete EndShipper information for each of your users.

Please note that the address and contact details are of the person or business entity responsible for the shipment and not necessarily the shipping location. Additionally, the address must be fully qualified and P.O. boxes are not allowed. The `company_name` can be a contact name, if appropriate.

After completing [Step 1](#step-1-run-the-exportpy-script), you have several options to ensure accurate credential data. You can open the .CSV using your preferred editor and manually validate and update the details for each row. Alternatively, you could programmatically update this information using your own records. As long as the data is accurate and format stays unmodified, you're ready to proceed to [Step 3](#step-3-run-the-importpy-script)!

### Step 3: Run the `import.py` script

This script imports the modified records obtained in [Step 1](#step-1-run-the-exportpy-script) and updated in [Step 2](#step-2-update-the-child_accountscsv-file-with-accurate-information). It takes in each row of the CSV, and updates the associated carrier account in the EasyPost API. It will report warnings to stdout for any row that is missing complete credential details.

The script does this by:

- Uses the parent accounts production API key, pull all children and their API keys
- Reads in the CSV data
- For each child user in the CSV file, re-authenticate using the matching API key
- For each Carrier Account associated with that user, fetch the Carrier Account record using the Carrier Account id
- Update the Carrier Account credentials using the information from the CSV file

To run the script:

`python3 import.py -k <EASYPOST_PROD_API_KEY>`

It is **highly recommended** for users with many child accounts to pipe the log output of this script to a file for easier viewing upon completion.
