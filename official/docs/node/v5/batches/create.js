const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const batch = new api.Batch({
  shipments: [{ id: 'shp_...' }, { id: 'shp_...' }],
});

batch.save().then(console.log);
