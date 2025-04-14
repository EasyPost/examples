import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_pagination_get_next_page(test_client):
    shipments = test_client.shipment.all(
        page_size=5,
    )

    test_client.shipment.get_next_page(shipments, page_size=5)

    build_response_snippet(interaction_index=1)
