package shipping_refund

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, _ := client.RefundShipment("shp_...")

	fmt.Println(shipment)
}
