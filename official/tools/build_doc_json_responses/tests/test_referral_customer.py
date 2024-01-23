import os
from unittest.mock import patch

import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)

REFERRAL_USER_PROD_API_KEY = os.getenv("REFERRAL_USER_PROD_API_KEY", "123")


def test_referral_customers_add_payment_method_with_credit_card(partner_user_prod_client):
    response_dict = {
        "id": "card_...",
        "disabled_at": None,
        "object": "CreditCard",
        "name": None,
        "last4": "1234",
        "exp_month": 7,
        "exp_year": 2024,
        "brand": "MasterCard",
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_referral_customers_add_payment_method_with_bank_account(partner_user_prod_client):
    response_dict = {
        "id": "ba_...",
        "disabled_at": None,
        "object": "BankAccount",
        "bank_name": "WELLS FARGO",
        "last4": "1234",
        "country": "US"
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_referral_customers_refund_by_amount(partner_user_prod_client):
    response_dict = {
        "refunded_amount": 2000,
        "payment_log_id": "paylog_...",
        "refunded_payment_logs": ["paylog...", "paylog..."],
        "errors": [],
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_referral_customers_refund_by_payment_log(partner_user_prod_client):
    response_dict = {
        "refunded_amount": 2000,
        "payment_log_id": "paylog_...",
        "refunded_payment_logs": ["paylog...", "paylog..."],
        "errors": [],
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


@pytest.mark.vcr()
def test_referral_customers_create(partner_user_prod_client):
    """This test requires a partner user's production API key via PARTNER_USER_PROD_API_KEY."""
    partner_user_prod_client.referral_customer.create(
        name="test test",
        email="test@test.com",
        phone="8888888888",
    )

    build_response_snippet()


@pytest.mark.vcr()
def test_referral_customers_update(partner_user_prod_client):
    """This test requires a partner user's production API key via PARTNER_USER_PROD_API_KEY."""
    referral_users = partner_user_prod_client.referral_customer.all()
    partner_user_prod_client.referral_customer.update_email(
        id=referral_users.referral_customers[0].id,
        email="email@example.com",
    )

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_referral_customers_list(partner_user_prod_client, page_size):
    """This test requires a partner user's production API key via PARTNER_USER_PROD_API_KEY."""
    partner_user_prod_client.referral_customer.all(page_size=page_size)

    build_response_snippet()
