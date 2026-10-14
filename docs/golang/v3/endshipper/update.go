package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	endShipper, _ := client.GetEndShipper("es_...")

	endShipper.Name = "NEW NAME"
	endShipper.Company = "BAZ"
	endShipper.Street1 = "164 TOWNSEND STREET UNIT 1"
	endShipper.Street2 = "UNIT 1"
	endShipper.City = "San Francisco"
	endShipper.State = "CA"
	endShipper.Zip = "94107"
	endShipper.Country = "US"
	endShipper.Phone = "555-555-5555"
	endShipper.Email = "FOO@EXAMPLE.COM"

	updatedEndShipper, _ := client.UpdateEndShippers(endShipper)

	fmt.Println(updatedEndShipper)
}
