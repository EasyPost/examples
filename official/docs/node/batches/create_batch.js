const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const batch = new api.Batch({
  shipments: ['shp_...', 'shp_...'],
});

batch.save().then(console.log);
