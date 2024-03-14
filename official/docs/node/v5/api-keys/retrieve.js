const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

// Retrieve all API keys including children
api.ApiKey.all().then(console.log).catch(console.log);

// Retrieve API keys for a specific child user
api.User.retrieve('user_...').then((child) => console.log(child.api_keys));
