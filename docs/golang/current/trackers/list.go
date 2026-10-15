package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	trackers, _ := client.ListTrackers(
		&easypost.ListTrackersOptions{
			PageSize: 5,
		},
	)

	fmt.Println(trackers)
}
