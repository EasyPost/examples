const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const report = new api.Report({
    start_date: '2016-10-01',
    end_date: '2016-10-31'
  });
  report.save().then(console.log);
