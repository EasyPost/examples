package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

    tracker, err := client.CreateTracker(
        &easypost.CreateTrackerOptions{
            TrackingCode: "9400110898825022579493",
            Carrier:      "USPS",
        },
    )

	fmt.Println(tracker)
}
