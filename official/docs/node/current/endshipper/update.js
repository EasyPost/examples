const EasyPostClient = require('@easypost/api');
const client = new EasyPostClient('<YOUR_TEST/PRODUCTION_API_KEY>');

(async () => {
  const endShipper = await client.EndShipper.retrieve('es_...');

  const updatedEndShipper = await client.EndShipper.update(endShipper.id, {
    name: 'NEW NAME',
    company: 'BAZ',
    street1: '164 TOWNSEND STREET UNIT 1',
    street2: 'UNIT 1',
    city: 'SAN FRANCISCO',
    state: 'CA',
    zip: '94107',
    country: 'US',
    phone: '555-555-5555',
    email: 'FOO@EXAMPLE.COM',
  });

  console.log(updatedEndShipper);
})();
