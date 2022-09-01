import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

customs_info = easypost.CustomsInfo.create(
    eel_pfc="NOEEI 30.37(a)",
    customs_certify=True,
    customs_signer="Steve Brule",
    contents_type="merchandise",
    contents_explanation="",
    restriction_type="none",
    customs_items=[
        {
            "description": "Sweet shirts",
            "quantity": 2,
            "weight": 11,
            "value": 23,
            "hs_tariff_number": "654321",
            "origin_country": "US",
        }
    ],
)

print(customs_info)
