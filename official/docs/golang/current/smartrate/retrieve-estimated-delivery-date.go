package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieveEstimatedDeliveryDate() {
	client := easypost.New("EASYPOST_API_KEY")

	estimatedDeliveryDates, _ := client.GetShipmentEstimatedDeliveryDate("shp_...", "YYYY-MM-DD")

	fmt.Println(estimatedDeliveryDates)
}
