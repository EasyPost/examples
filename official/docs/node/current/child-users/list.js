const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const childUsers = await client.User.allChildren({
    page_size: 5,
  });

  console.log(childUsers);
})();
