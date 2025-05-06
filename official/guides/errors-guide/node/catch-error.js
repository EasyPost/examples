const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  // When the `errors` key is returned as an array of FieldError objects
  try {
    // Simulate a request with missing parameters
    await client.Shipment.create({});
  } catch (error) {
    console.error(error.errors[0].message);
  }

  // When the `errors` key is returned as an array of strings
  try {
    const claimParameters = {
      tracking_code: '123', // Simulate a request with an invalid tracking code
    };
    await client.Claim.create(claimParameters);
  } catch (error) {
    console.error(error.errors[0]);
  }
})();
