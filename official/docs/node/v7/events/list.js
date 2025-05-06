const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const events = await client.Event.all({
    page_size: 5,
  });

  console.log(events);
})();
