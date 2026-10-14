package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.RerateShipment("shp_...")

	fmt.Println(shipment)
}
