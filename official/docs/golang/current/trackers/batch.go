package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func batch() {
	client := easypost.New("EASYPOST_API_KEY")

	trackers, _ := client.RetrieveTrackerBatch(
		&easypost.ListTrackersOptions{
			TrackingCodes: []string{"EZ1000000001", "EZ1000000002"},
		},
	)

	fmt.Println(trackers)
}
