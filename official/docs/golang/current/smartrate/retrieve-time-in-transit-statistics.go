package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieveTimeInTransitStatistics() {
	client := easypost.New("EASYPOST_API_KEY")

	smartRates, _ := client.GetShipmentSmartrates("shp_...")

	fmt.Println(smartRates)
}
