package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

    shipment, err := client.GetShipment("shp_...")

    batch, err := client.RemoveShipmentsFromBatch("batch_...", shipment)

	fmt.Println(batch) 
}
