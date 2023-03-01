const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const parcel = await client.Parcel.create({
    length: 20.2,
    width: 10.9,
    height: 5,
    weight: 65.9,
  });

  console.log(parcel);
})();
