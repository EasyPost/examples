package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func label() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipmentLabel("shp_...", "ZPL")

	fmt.Println(shipment)
}
