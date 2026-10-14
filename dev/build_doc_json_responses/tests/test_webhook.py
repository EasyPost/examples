import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_webhooks_create(test_client, webhook_create):
    webhook = test_client.webhook.create(**webhook_create)

    try:
        build_response_snippet()
    finally:
        # we are deleting the webhook here so we don't keep sending events to a dead webhook.
        test_client.webhook.delete(id=webhook.id)


@pytest.mark.vcr()
def test_webhooks_retrieve(test_client, webhook_create):
    webhook = test_client.webhook.create(**webhook_create)

    try:
        test_client.webhook.retrieve(id=webhook.id)
        build_response_snippet(interaction_index=1)
    finally:
        # we are deleting the webhook here so we don't keep sending events to a dead webhook.
        test_client.webhook.delete(id=webhook.id)


@pytest.mark.vcr()
def test_webhooks_list(test_client, webhook_create, page_size):
    webhook = test_client.webhook.create(**webhook_create)

    try:
        test_client.webhook.all(page_size=page_size)
        build_response_snippet(interaction_index=1)
    finally:
        # we are deleting the webhook here so we don't keep sending events to a dead webhook.
        test_client.webhook.delete(id=webhook.id)


@pytest.mark.vcr()
def test_webhooks_update(test_client, webhook_create, webhook_update):
    webhook = test_client.webhook.create(**webhook_create)

    try:
        test_client.webhook.update(id=webhook.id, **webhook_update)
        build_response_snippet(interaction_index=1)
    finally:
        # we are deleting the webhook here so we don't keep sending events to a dead webhook.
        test_client.webhook.delete(id=webhook.id)


@pytest.mark.vcr()
def test_webhooks_delete(test_client, webhook_create):
    webhook = test_client.webhook.create(**webhook_create)
    test_client.webhook.delete(id=webhook.id)

    build_response_snippet(interaction_index=1)
