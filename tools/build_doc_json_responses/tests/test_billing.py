import os

import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)


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


@pytest.mark.vcr()
def test_billing_create_stripe_bank_account_secret(prod_client):
    prod_client.beta_referral_customer.create_bank_account_client_secret()

    build_response_snippet()


@pytest.mark.vcr()
def test_billing_create_stripe_credit_card_secret(prod_client):
    prod_client.beta_referral_customer.create_credit_card_client_secret()

    build_response_snippet()


def test_billing_add_stripe_bank_account(prod_client):
    response_dict = {
        "bank_name": "STRIPE TEST BANK",
        "country": "US",
        "disabled_at": None,
        "id": "pm_...",
        "last4": "6789",
        "object": "BankAccount",
        "requires_mandate_collection": False,
        "verified": True,
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_billing_add_stripe_credit_card(prod_client):
    response_dict = {
        "id": "card_...",
        "disabled_at": None,
        "object": "CreditCard",
        "requires_mandate_collection": False,
        "name": None,
        "last4": "1234",
        "exp_month": 1,
        "exp_year": 2025,
        "brand": "Visa",
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)
