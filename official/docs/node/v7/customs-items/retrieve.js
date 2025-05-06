const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const customsItem = await client.CustomsItem.retrieve('cstitem_...');

  console.log(customsItem);
})();
