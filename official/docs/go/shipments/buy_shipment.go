package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

    shipment, err = client.BuyShipment("shp_...", "rate_...", "249.99")

	fmt.Println(shipment)
}
