const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  try {
    await client.Address.create({ strict_verify: true });
  } catch (error) {
    console.error(error.code);
  }
})();
