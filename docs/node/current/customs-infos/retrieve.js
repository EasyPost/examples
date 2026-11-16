const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const customsInfo = await client.CustomsInfo.retrieve('cstinfo_...');

  console.log(customsInfo);
})();
