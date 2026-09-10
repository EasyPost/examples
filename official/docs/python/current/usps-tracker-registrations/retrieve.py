import requests

response = requests.get(
    "https://api.easypost.com/v2/carrier_claims/usps_tracker_registrations/utr_0123456789abcdef0123456789abcdef",
    auth=("EASYPOST_API_KEY", ""),
)
print(response.json())
