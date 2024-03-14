package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	tracker, _ := client.CreateTracker(
		&easypost.CreateTrackerOptions{
			TrackingCode: "EZ1000000001",
			Carrier:      "USPS",
		},
	)

	fmt.Println(tracker)
}
