package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    shipment, err := client.GetShipment("shp_...")
    rate, err := client.LowestRate(shipment)

    shipment, err = client.BuyShipmentWithCarbonOffset("shp_...", &rate, "100.00")
}
