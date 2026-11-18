package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieveStandaloneSmartrateDeliverOn() {
	client := easypost.New("EASYPOST_API_KEY")

	params := &easypost.RecommendShipDateForZipPairParams{
		FromZip:             "10001",
		ToZip:               "10002",
		Carriers:            []string{"UPS", "FedEx"},
		DesiredDeliveryDate: "2024-07-18",
	}

	recommendations, _ := client.RecommendShipDateForZipPair(params)

	fmt.Println(recommendations)
}
