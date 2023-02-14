const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const tracker = new api.Tracker({
  tracking_code: 'EZ1000000001',
  carrier: 'USPS',
});

tracker.save().then(console.log);
