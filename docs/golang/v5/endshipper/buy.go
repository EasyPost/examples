package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func buy() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	rate, _ := client.LowestShipmentRate(shipment)

	shipment, _ = client.BuyShipmentWithEndShipper(shipment.ID, &rate, "0", "es_...")

	fmt.Println(shipment)
}
