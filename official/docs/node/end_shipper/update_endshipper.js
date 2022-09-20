const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_TEST/PRODUCTION_API_KEY>');

const endShipper = api.EndShipper.retrieve('es_...');

endShipper.name = 'NEW NAME';
endShipper.company = 'BAZ';
endShipper.street1 = '164 TOWNSEND STREET UNIT 1';
endShipper.street2 = 'UNIT 1';
endShipper.city = 'SAN FRANCISCO';
endShipper.state = 'CA';
endShipper.zip = '94107';
endShipper.country = 'US';
endShipper.phone = '555-555-5555';
endShipper.email = 'FOO@EXAMPLE.COM';

endShipper.save().then(console.log);
