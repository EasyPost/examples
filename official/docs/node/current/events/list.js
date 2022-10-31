const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Event.all({
  page_size: 5,
}).then(console.log);
