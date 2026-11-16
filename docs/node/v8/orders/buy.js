const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const boughtOrder = await client.Order.buy('order_...', 'FedEx', 'FEDEX_GROUND');

  console.log(boughtOrder);
})();
