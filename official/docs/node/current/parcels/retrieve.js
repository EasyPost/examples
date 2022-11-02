const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Parcel.retrieve('prcl_...').then(console.log);
