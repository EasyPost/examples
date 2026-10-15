const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Batch.retrieve('batch_...').then((batch) => {
  batch.createScanForm().then(console.log);
});
