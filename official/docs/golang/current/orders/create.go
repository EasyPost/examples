package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")
	shipment, _ := client.GetShipment("shp_...")

	order, _ := client.CreateOrder(
		&easypost.Order{
			ToAddress:   toAddress,
			FromAddress: fromAddress,
			Shipments: []*easypost.Shipment{
				shipment,
			},
		},
	)

	fmt.Println(order)
}
