const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

// Replace `payment_log` with any of the report types listed above
api.Report.all('payment_log', { page_size: 5 }).then(console.log);
