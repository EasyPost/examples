to_address = easypost.Address.create(...)
from_address = easypost.Address.create(...)
parcel = easypost.Parcel.create(
    predefined_package="Parcel",
    weight=28,
)

shipment = easypost.Shipment.create(
    to_address=to_address,
    from_address=from_address,
    parcel=parcel,
)

shipment.buy(rate=shipment.lowest_rate())
