const parcel = new api.Parcel({
  length: 9,
  width: 6,
  height: 2,
  weight: 10,
});

parcel.save().then(console.log);
