package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	shipment, err := client.GetShipment("shp_...")

	shipmentWithForm, err := client.GenerateShipmentForm(shipment, "return_packing_slip")

	fmt.Println(shipmentWithForm)
}
