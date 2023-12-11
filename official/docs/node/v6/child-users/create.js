const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const user = await client.User.create({
    name: 'Child Account Name',
  });

  console.log(user);
})();
