const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Report.all('payment_log', { page_size: 4 }).then(console.log);
