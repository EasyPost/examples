import easypost

customs_item1 = easypost.CustomsItem.create(
    description="T-shirt",
    quantity=1,
    value=11,
    weight=6,
    hs_tariff_number="610910",
    origin_country="US",
)
