package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, err := client.GetShipmentLabel("shp_...", "ZPL")

	fmt.Println(shipment)
}
