const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const insurance = await client.Insurance.retrieve('ins_...');

  console.logP(insurance);
})();
