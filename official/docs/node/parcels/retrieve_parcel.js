const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Parcel.retrieve('prcl_...').then(console.log);
