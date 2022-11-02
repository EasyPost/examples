package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, _ := client.GetShipment("shp_...")
	rate, _ := client.LowestRate(shipment)

	shipment, _ = client.BuyShipment(shipment.ID, &rate, "249.99")

	fmt.Println(shipment)
}
