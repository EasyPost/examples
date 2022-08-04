const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

batch = new api.Batch({
    shipments: ['shp_...'],
    shipments: ['shp_...']
  });
  
console.log(batch)
