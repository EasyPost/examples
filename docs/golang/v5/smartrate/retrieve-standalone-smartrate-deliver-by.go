package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieveStandaloneSmartrateDeliverBy() {
	client := easypost.New("EASYPOST_API_KEY")

	params := &easypost.EstimateDeliveryDateForZipPairParams{
		FromZip:         "10001",
		ToZip:           "10002",
		Carriers:        []string{"UPS", "FedEx"},
		PlannedShipDate: "2024-07-18",
	}

	estimates, _ := client.EstimateDeliveryDateForZipPair(params)

	fmt.Println(estimates)
}
