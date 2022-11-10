const customsInfo = new api.CustomsInfo({
  eel_pfc: 'NOEEI 30.37(a)',
  customs_certify: true,
  customs_signer: 'Jarrett Streebin',
  contents_type: 'gift',
  customs_items: [customsItem1, customsItem2],
});

customsInfo.save().then(console.log);
