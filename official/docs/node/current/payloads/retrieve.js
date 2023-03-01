const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const payload = await client.Event.retrievePayload('evt_...', 'payload_...');

  console.log(payload);
})();
