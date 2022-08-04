const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Insurance.all({
    page_size: 5,
    start_datetime: '2016-01-02T08:50:00Z',
  }).then(console.log);
