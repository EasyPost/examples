package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	estimatedDeliveryDates, _ := client.GetShipmentEstimatedDeliveryDate(shipment.ID, "YYYY-MM-DD")

	fmt.Println(estimatedDeliveryDates)
}
