package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, _ := client.GetShipment("shp_...")
	estimatedDeliveryDates, _ := client.GetShipmentEstimatedDeliveryDate(shipment.ID, "YYYY-MM-DD")

	fmt.Println(estimatedDeliveryDates)
}
