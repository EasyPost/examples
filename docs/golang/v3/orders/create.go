package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

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
