const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const insurance = new api.Insurance({
    to_address: {id: "adr_..."},
    from_address: {id: "adr_..."},
    tracking_code: '9400110898825022579493',
    carrier: 'USPS',
    amount: '100.00',
    reference: 'insuranceRef1'
});
  
insurance.save().then(console.log);
