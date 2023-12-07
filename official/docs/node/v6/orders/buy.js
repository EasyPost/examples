const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const order = await client.Order.retrieve('order_...');

  const boughtOrder = await client.Order.buy(order.id, 'FedEx', 'FEDEX_GROUND');

  console.log(boughtOrder);
})();
