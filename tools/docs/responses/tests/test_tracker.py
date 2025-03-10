import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_trackers_create(tracker_create):
    easypost.Tracker.create(**tracker_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_trackers_retrieve(page_size):
    trackers = easypost.Tracker.all(page_size=page_size)
    easypost.Tracker.retrieve(trackers["trackers"][0].id)

    build_response_snippet(interaction_index=1)
