
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_trackers_create(test_client, tracker_create):
    test_client.tracker.create(**tracker_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_trackers_retrieve(test_client, page_size):
    trackers = test_client.tracker.all(page_size=page_size)
    test_client.tracker.retrieve(id=trackers["trackers"][0].id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_trackers_list(test_client, page_size):
    test_client.tracker.all(page_size=page_size)

    build_response_snippet()
