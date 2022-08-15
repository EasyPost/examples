package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, err := client.InsureShipment("shp_...", "100.00")

	fmt.Println(shipment)
}
