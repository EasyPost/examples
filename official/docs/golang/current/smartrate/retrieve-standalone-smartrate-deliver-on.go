package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	params := &easypost.RecommendShipDateForZipPairParams{
		OriginPostalCode:      "10001",
		DestinationPostalCode: "10002",
		Carriers:              []string{"UPS", "FedEx"},
		DesiredDeliveryDate:   "2024-07-18",
	}

	recommendations, _ := client.RecommendShipDateForZipPair(params)

	fmt.Println(recommendations)
}
