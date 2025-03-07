import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_webhooks_create(webhook_create):
    webhook = easypost.Webhook.create(**webhook_create)

    webhook.delete()  # we are deleting the webhook here so we don't keep sending events to a dead webhook.

    build_response_snippet()


@pytest.mark.vcr()
def test_webhooks_retrieve(webhook_create):
    webhook = easypost.Webhook.create(**webhook_create)
    easypost.Webhook.retrieve(webhook.id)

    webhook.delete()  # we are deleting the webhook here so we don't keep sending events to a dead webhook.

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_webhooks_list(webhook_create, page_size):
    webhook = easypost.Webhook.create(**webhook_create)
    easypost.Webhook.all(page_size=page_size)

    webhook.delete()  # we are deleting the webhook here so we don't keep sending events to a dead webhook.

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_webhooks_update(webhook_create):
    webhook = easypost.Webhook.create(**webhook_create)
    webhook.update()

    webhook.delete()  # we are deleting the webhook here so we don't keep sending events to a dead webhook.

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_webhooks_delete(webhook_create):
    webhook = easypost.Webhook.create(**webhook_create)
    webhook.delete()

    build_response_snippet(interaction_index=1)
