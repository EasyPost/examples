const Easypost = require('@easypost/api');
const api = new Easypost('{API_KEY}');

api.Address.save({
  strict_verify: true,
}).catch((error) => {
  console.error(error.code);
});
