curl -X POST https://api.easypost.com/v2/shipments/shp_.../buy \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "rate": {
      "id": "rate_..."
    },
    "end_shipper_id": "es_..."
  }'
