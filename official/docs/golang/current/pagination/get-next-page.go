package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	// Get first page of results
	shipments, _ := client.ListShipments(
		&easypost.ListShipmentsOptions{
			PageSize: 5,
		},
	)

	// Provide the previous results page to move onto the next page
	secondPage, _ := client.GetNextShipmentPage(shipments)

	// You can also ask for the next page to be of a specific size
	lastPage, _ := client.GetNextShipmentPageWithPageSize(secondPage, 10)

	fmt.Println(lastPage)
}
