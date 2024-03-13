package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	rate, _ := client.LowestShipmentRate(shipment)

	shipment, _ = client.BuyShipment(shipment.ID, &rate, "249.99")

	fmt.Println(shipment)
}
