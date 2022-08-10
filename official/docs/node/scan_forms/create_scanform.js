const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const scanform = new api.ScanForm({
  shipments: ['shp_...', 'shp_...'],
});

scanform.save().then(console.log);
