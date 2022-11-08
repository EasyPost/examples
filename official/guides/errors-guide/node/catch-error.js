const Easypost = require('@easypost/api');
const api = new Easypost('{API_KEY}');

easypost.Address.save({
  ...,
  "strict_verify": true
}).catch(e => {
  console.log(e);
});
