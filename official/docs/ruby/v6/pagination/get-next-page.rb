require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

# Get first page of results
shipments = client.shipment.all(page_size: 5)

# Provide the previous results page to move onto the next page
next_page = client.shipment.get_next_page(shipments)

puts next_page
