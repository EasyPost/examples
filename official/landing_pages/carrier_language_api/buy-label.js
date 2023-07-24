const to_address = new api.Address(...);
const from_address = new api.Address(...);
const parcel = new api.Parcel({
  predefined_package: "Parcel",
  weight: 28,
});

const shipment = new api.Shipment({
  to_address: to_address,
  from_address: from_address,
  parcel: parcel
});

shipment.save().then(() => {
  shipment.buy(shipment.lowestRate().then(console.log))
});
