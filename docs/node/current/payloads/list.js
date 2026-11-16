const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const payloads = await client.Event.retrieveAllPayloads('evt_...');

  console.log(payloads);
})();
