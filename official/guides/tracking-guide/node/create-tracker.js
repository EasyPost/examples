// Creating a Tracker
const tracker = new api.Tracker({
    tracking_code: 'EZ4000000004',
    carrier: 'UPS',
});

tracker.save().then(console.log);
