package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")

	batch, _ := client.CreateBatch(shipment)

	fmt.Println(batch)
}
