import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.luma.get_promise(
    to_address={
        "name": "Dr. Steve Brule",
        "street1": "5744 Silverton Ave",
        "city": "McKinney",
        "state": "TX",
        "zip": "75070",
        "country": "US",
        "phone": "8573875756",
        "email": "dr_steve_brule@gmail.com",
    },
    from_address={
        "name": "EasyPost",
        "street1": "417 Montgomery Street",
        "street2": "5th Floor",
        "city": "San Francisco",
        "state": "CA",
        "zip": "94104",
        "country": "US",
        "phone": "4153334445",
        "email": "support@easypost.com",
    },
    parcel={
        "length": 20.2,
        "width": 10.9,
        "height": 5,
        "weight": 65.9,
    },
    ruleset_name="required_deliver_by_date",
    planned_ship_date="2025-07-24",
    deliver_by_date="2025-07-26",
)

print(shipment)
