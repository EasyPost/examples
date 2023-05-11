const parcel = new api.Parcel({
    predefined_package: 'FlatRateEnvelope',
    weight: 10,
});

parcel.save().then(console.log);
