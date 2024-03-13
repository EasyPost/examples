const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const event = await client.Event.retrieve('evt_...');

  console.log(event);
})();
