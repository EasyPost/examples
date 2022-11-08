// Creating a Tracker
tracker, err := client.CreateTracker(
    &easypost.CreateTrackerOptions{
        Carrier: "UPS",
        TrackingCode: "EZ4000000004",
    },
)
