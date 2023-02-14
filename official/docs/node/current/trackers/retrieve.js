const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const tracker = await client.Tracker.retrieve('trk_...');

  console.log(tracker);
})();
