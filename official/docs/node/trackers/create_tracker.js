const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const tracker = new api.Tracker({
  tracking_code: '9400110898825022579493',
  carrier: 'USPS',
});

tracker.save().then(console.log);
