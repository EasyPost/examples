const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const trackers = await client.Tracker.retrieveBatch({
    tracking_codes: ['EZ1000000001', 'EZ1000000002'],
  });

  console.log(trackers);
})();
