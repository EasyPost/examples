const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const carrier_account = new api.CarrierAccount({
    type: 'DhlEcsAccount',
    description: 'CA Location DHL eCommerce Solutions Account',
    credentials: {
      client_id: "123456",
      client_secret: "123abc",
      distribution_center: "USLAX1",
      pickup_id: "123456"
    },
    test_credentials: {
      client_id: "123456",
      client_secret: "123abc",
      distribution_center: "USLAX1",
      pickup_id: "123456"
    }
  });
  
  carrier_account.save().then(console.log);
