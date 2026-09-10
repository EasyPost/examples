import requests

response = requests.get(
    "https://api.easypost.com/v2/carrier_claims/usps_tracker_registrations",
    auth=("EASYPOST_API_KEY", ""),
)
print(response.json())
