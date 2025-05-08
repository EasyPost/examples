import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

# Get first page of results
shipments = client.shipment.all(
    page_size=5,
)

# Provide the previous results page to move onto the next page
next_page = client.shipments.get_next_page(shipments)

print(next_page)
