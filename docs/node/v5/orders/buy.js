const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Order.retrieve('order_...').then((order) => {
  order.buy('FedEx', 'FEDEX_GROUND').then(console.log);
});
