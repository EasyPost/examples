using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

EasyPost::Shipment.create(
  to_address: to_address,
  from_address: from_address,
  parcel: parcel,
  is_return: true
);
