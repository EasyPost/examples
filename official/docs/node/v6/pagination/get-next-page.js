const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  // Get first page of results
  const shipments = await client.Shipment.all({
    page_size: 5,
  });

  // Provide the previous results page to move onto the next page
  const nextPage = await client.Shipment.getNextPage(shipments);

  console.log(nextPage);
})();
