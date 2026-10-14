package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	rate, _ := client.LowestRate(shipment)

	shipment, _ = client.BuyShipmentWithCarbonOffset("shp_...", &rate, "100.00")

	fmt.Println(shipment)
}
