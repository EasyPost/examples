const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const parcel = await client.Parcel.retrieve('prcl_...');

  console.log(parcel);
})();
