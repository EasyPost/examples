shipment.buy(rateId).then(() => {
  console.log(shipment.postage_label.label_url);
  console.log(shipment.postage_label.tracking_code);
});
