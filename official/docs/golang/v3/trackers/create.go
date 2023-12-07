package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	tracker, _ := client.CreateTracker(
		&easypost.CreateTrackerOptions{
			TrackingCode: "EZ1000000001",
			Carrier:      "USPS",
		},
	)

	fmt.Println(tracker)
}
