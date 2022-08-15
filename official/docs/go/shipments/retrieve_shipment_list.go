package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipments, err := client.ListShipments(
		&easypost.ListShipmentsOptions{
			PageSize:      5,
			StartDateTime: "2016-01-02T08:50:00Z",
		},
	)

	fmt.Println(shipments)
}
