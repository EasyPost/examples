package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieveRecommendShipDate() {
	client := easypost.New("EASYPOST_API_KEY")

	rates, _ := client.RecommendShipDateForShipment("shp_...", "YYYY-MM-DD")

	fmt.Println(rates)
}
