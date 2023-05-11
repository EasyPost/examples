const customsItem1 = new api.CustomsItem({
    description: 'T-shirt',
    quantity: 1,
    value: 11,
    weight: 6,
    hs_tariff_number: '610910',
    origin_country: 'US',
});

customsItem1.save().then(console.log);
