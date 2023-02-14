const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const insurances = await client.Insurance.all({
    page_size: 5,
  });

  console.log(insurances);
})();
