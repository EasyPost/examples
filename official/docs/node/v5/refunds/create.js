const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const refundData = {
  carrier: 'USPS',
  tracking_codes: ['EZ1000000001'],
};

api.Refund.save(refundData).then(console.log);
