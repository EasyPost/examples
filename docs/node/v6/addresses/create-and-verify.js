const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const address = await client.Address.createAndVerify({
    street1: '417 montgomery street',
    street2: 'FL 5',
    city: 'San Francisco',
    state: 'CA',
    zip: '94104',
    country: 'US',
    company: 'EasyPost',
    phone: '415-123-4567',
  });

  console.log(address);
})();
