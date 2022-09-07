const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const batch = api.Batch.retrieve('batch_...');

batch.addShipments([{ id: 'shp_...' }, { id: 'shp_...' }]).then(console.log);
