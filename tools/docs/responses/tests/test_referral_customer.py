import os
from unittest.mock import patch

import easypost
import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)


REFERRAL_USER_PROD_API_KEY = os.getenv("REFERRAL_USER_PROD_API_KEY", "123")


def test_referral_customers_add_payment_method():
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


def test_referral_customers_refund_by_amount():
    response_dict = {
        "refunded_amount": 2000,
        "payment_log_id": "paylog_...",
        "refunded_payment_logs": ["paylog...", "paylog..."],
        "errors": [],
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_referral_customers_refund_by_payment_log():
    response_dict = {
        "refunded_amount": 2000,
        "payment_log_id": "paylog_...",
        "refunded_payment_logs": ["paylog...", "paylog..."],
        "errors": [],
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


@pytest.mark.vcr()
def test_referral_customers_create(partner_prod_api_key):
    """This test requires a partner user's production API key via PARTNER_USER_PROD_API_KEY."""
    easypost.Referral.create(
        name="test test",
        email="test@test.com",
        phone="8888888888",
    )

    build_response_snippet()


@pytest.mark.vcr()
def test_referral_customers_update(partner_prod_api_key):
    """This test requires a partner user's production API key via PARTNER_USER_PROD_API_KEY."""
    referral_users = easypost.Referral.all()
    easypost.Referral.update_email(
        "email@example.com",
        referral_users.referral_customers[0].id,
    )

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_referral_customers_list(partner_prod_api_key, page_size):
    """This test requires a partner user's production API key via PARTNER_USER_PROD_API_KEY."""
    easypost.Referral.all(page_size=page_size)

    build_response_snippet()
