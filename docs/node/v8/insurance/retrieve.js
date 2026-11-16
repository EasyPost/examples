const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const insurance = await client.Insurance.retrieve('ins_...');

  console.log(insurance);
})();
