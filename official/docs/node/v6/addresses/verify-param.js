const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const address = await client.Address.create({
    verify: true,
    street1: '417 Montgomery Street',
    street2: '5',
    city: 'SF',
    state: 'CA',
    zip: '94104',
    country: 'US',
    company: 'EasyPost',
    phone: '415-123-4567',
  });

  console.log(address);
})();
