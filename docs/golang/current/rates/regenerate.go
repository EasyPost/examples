package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func regenerate() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.RerateShipment("shp_...")

	fmt.Println(shipment)
}
