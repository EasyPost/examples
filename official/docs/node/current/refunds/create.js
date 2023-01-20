const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const refundData = {
  carrier: 'USPS',
  tracking_codes: ['XXXXXXX'],
};

api.Refund.save(refundData).then(console.log);
