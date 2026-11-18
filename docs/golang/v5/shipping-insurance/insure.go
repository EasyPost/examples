package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func insure() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.InsureShipment("shp_...", "100.00")

	fmt.Println(shipment)
}
