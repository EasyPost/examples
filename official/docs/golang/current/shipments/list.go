package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	shipments, _ := client.ListShipments(
		&easypost.ListShipmentsOptions{
			PageSize: 5,
		},
	)

	fmt.Println(shipments)
}
