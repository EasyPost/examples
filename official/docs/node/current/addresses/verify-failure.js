const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const address = await client.Address.create({
    street1: '000 unknown street',
    city: 'Not A City',
    state: 'ZZ',
    zip: '00001',
    country: 'US',
    email: 'test@example.com',
    phone: '5555555555',
  });

  console.log(address);
})();
