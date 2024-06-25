curl -X POST https://api.easypost.com/v2/batches \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "batch": {
      "shipments": [
        "from_address": {"id": "adr_..."},
        "to_address": {"id": "adr_..."},
        "parcel": {"id": "prcl_..."},
        "service": "First",
        "carrier": "USPS",
        "carrier_accounts": ["ca_..."]
      ]
    }
  }'

curl -X POST https://api.easypost.com/v2/batches/batch_.../buy \
  -u "EASYPOST_API_KEY":
