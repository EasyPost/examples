package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	params := &easypost.EstimateDeliveryDateForZipPairParams{
		OriginPostalCode:      "10001",
		DestinationPostalCode: "10002",
		Carriers:              []string{"UPS", "FedEx"},
		PlannedShipDate:       "2024-07-18",
	}

	estimates, _ := client.EstimateDeliveryDateForZipPair(params)

	fmt.Println(estimates)
}
