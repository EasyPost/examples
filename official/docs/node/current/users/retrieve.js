const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

// Retrieve the authenticated user
api.User.retrieveMe().then(console.log);

// Retrieve a child user
api.User.retrieve('user_...').then(console.log);
