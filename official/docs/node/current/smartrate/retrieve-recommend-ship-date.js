const EasyPostClient = require("@easypost/api");

const client = new EasyPostClient("EASYPOST_API_KEY");

(async () => {
  const rates = await client.Shipment.recommendShipDate(
    "shp_...",
    "YYYY-MM-DD"
  );

  console.log(rates);
})();
