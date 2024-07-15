const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

const params = {
    from_zip: "10001",
    to_zip: "10002",
    desired_delivery_date: "2024-07-18",
    carriers: ["UPS"],
  };

(async () => {
  const results = await client.SmartRate.recommendShipDate(params);

  console.log(results);
})();
