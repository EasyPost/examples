def maersk_account_payload() -> dict:
    return {
        "carrier_account": {
            "type": "MaerskAccount",
            "description": "Maersk Account",
            "reference": None,
            "credentials": {
                "first_name": "VALUE",
                "last_name": "VALUE",
                "company_name": "VALUE",
                "email": "VALUE",
                "phone": "VALUE",
                "daily_number_of_shipments": "VALUE",
                "channel": "VALUE",
                "accepted_terms": "true",
                "serial_number": "VALUE",
                "origin_address_line_1": "VALUE",
                "origin_address_line_2": "VALUE",
                "origin_postal_code": "VALUE",
                "origin_city": "VALUE",
                "origin_state": "VALUE",
                "billing_address_line_1": "VALUE",
                "billing_address_line_2": "VALUE",
                "billing_postal_code": "VALUE",
                "billing_city": "VALUE",
                "billing_state": "VALUE",
            },
            "test_credentials": {},
        }
    }


def ups_oauth_registration_payload() -> dict:
    return {
        "carrier_account_oauth_registrations": {
            "type": "UpsAccount",
            "account_number": "CUSTOMER UPS ACCOUNT NUMBER",
            "description": "CUSTOMER ACCOUNT DESCRIPTION (optional)",
            "reference": "UNIQUE ACCOUNT REFERENCE (optional)",
            "return_to_url": "https://example.com (optional)",
        }
    }


def amazon_shipping_oauth_registration_payload() -> dict:
    return {
        "carrier_account_oauth_registrations": {
            "type": "AmazonShippingAccount",
            "description": "My Shipping Account (optional)",
            "reference": "Internal reference id (optional)",
            "return_to_url": "https://example.com (optional)",
            "credentials": {
                "account_type": "shipper",
                "account_country": "US",
            },
        }
    }


def doordash_account_payload() -> dict:
    return {
        "billToEasyPost": False,
        "credentials": {
            "developer_id": "VALUE",
            "key_id": "VALUE",
            "signing_secret": "VALUE",
            "pickup_external_business_id": "VALUE",
        },
        "test_credentials": {},
        "type": "DoorDashAccount",
    }
