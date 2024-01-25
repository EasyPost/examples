import os

from builder.snippets import save_raw_json


def test_billing_fund():
    response_dict = {}

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_billing_delete():
    response_dict = {}

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_billing_list():
    response_dict = {
        "id": "cust_...",
        "object": "PaymentMethods",
        "primary_payment_method": {
            "id": "card_...",
            "disabled_at": None,
            "object": "CreditCard",
            "name": None,
            "last4": "4242",
            "exp_month": 1,
            "exp_year": 2025,
            "brand": "Visa",
        },
        "secondary_payment_method": {
            "id": "card_...",
            "disabled_at": None,
            "object": "CreditCard",
            "name": None,
            "last4": "4444",
            "exp_month": 1,
            "exp_year": 2025,
            "brand": "Mastercard",
        },
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_billing_create_referral_token():
    response_dict = {"public_key": "pk_..."}

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_billing_create_ep_credit_card():
    response_dict = {
        "id": "card_...",
        "object": "CreditCard",
        "name": None,
        "last4": "1234",
        "exp_month": 1,
        "exp_year": 2025,
        "brand": "Visa",
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)
