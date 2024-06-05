package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipments, _ := client.ListShipments(
		&easypost.ListShipmentsOptions{
			PageSize: 5,
		},
	)

	fmt.Println(shipments)
}
