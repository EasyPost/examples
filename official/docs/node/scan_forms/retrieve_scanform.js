const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.ScanForm.retrieve('sf_...').then(console.log);
