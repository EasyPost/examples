const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.CustomsItem.retrieve('cstitem_...').then(console.log);
