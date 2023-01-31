const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Event.retrievePayload('evt_...', 'payload_...').then(console.log);
