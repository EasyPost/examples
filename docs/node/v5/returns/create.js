const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const shipment = new api.Shipment({
  parcel: {
    id: 'prcl_...',
  },
  to_address: {
    id: 'adr_...',
  },
  from_address: {
    id: 'adr_...',
  },
  is_return: true,
});

shipment.save().then(console.log);
