const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Report.retrieve('<REPORT_ID>').then(console.log);
