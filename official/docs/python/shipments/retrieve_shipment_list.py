import easypost
easypost.api_key = "EASYPOST_API_KEY"

shipments = easypost.Shipment.all(
  page_size = 5,
  start_datetime = "2016-01-02T08:50:00Z"
)

print(shipments)
