import requests

response = requests.post(
    "https://api.easypost.com/v2/carrier_claims/usps_tracker_registrations",
    auth=("EASYPOST_API_KEY", ""),
    json={
        "tracker_registrations": [
            {
                "tracking_code": "9400111899223344556677",
                "product_value": "25.50",
            }
        ]
    },
)
print(response.json())
