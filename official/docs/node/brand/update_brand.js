const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.User.retrieveMe().then(user => {
    const color = '#303F9F';
  
    user.updateBrand({color}).then(console.log);
  });
