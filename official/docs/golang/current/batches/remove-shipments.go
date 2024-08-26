package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func removeShipments() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")

	batch, _ := client.RemoveShipmentsFromBatch("batch_...", shipment)

	fmt.Println(batch)
}
