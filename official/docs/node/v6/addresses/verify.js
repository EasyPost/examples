const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const address = await client.Address.create({
    street1: '417 montgomery streat',
    city: 'SAN FRANCISCO',
    state: 'CA',
    zip: '94104',
    country: 'US',
    company: 'EasyPost',
    phone: '415-123-4567',
  });

  const verifiedAddress = await client.Address.verifyAddress(address.id);

  console.log(verifiedAddress);
})();
