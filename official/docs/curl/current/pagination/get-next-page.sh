# Get first page of results
curl -X GET "https://api.easypost.com/v2/shipments?page_size=5" \
  -u "EASYPOST_API_KEY":

# Provide the ID of the last element of the previous page in the before_id param
curl -X GET "https://api.easypost.com/v2/shipments?page_size=5&before_id=shp_..." \
  -u "EASYPOST_API_KEY":
