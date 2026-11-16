const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const customsInfo = await client.CustomsInfo.create({
    eel_pfc: 'NOEEI 30.37(a)',
    customs_certify: true,
    customs_signer: 'Steve Brule',
    contents_type: 'merchandise',
    contents_explanation: '',
    restriction_type: 'none',
    restriction_comments: '',
    customs_items: [
      {
        description: 'T-shirts',
        quantity: 1,
        weight: 5,
        value: 10,
        hs_tariff_number: '123456',
        origin_country: 'US',
      },
    ],
  });

  console.log(customsInfo);
})();
