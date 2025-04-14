import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_events_list(test_client, page_size):
    test_client.event.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_events_retrieve(test_client, page_size):
    events = test_client.event.all(page_size=page_size)
    test_client.event.retrieve(id=events["events"][0].id)

    build_response_snippet(interaction_index=1)
