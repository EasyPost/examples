package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	toAddress, err := client.GetAddress("shp_...")
	fromAddress, err := client.GetAddress("adr_...")
	parcel, err := client.GetParcel("prcl_...")

	shipment, err := client.CreateShipment(
		&easypost.Shipment{
			ToAddress:   toAddress,
			FromAddress: fromAddress,
			Parcel:      parcel,
			Options: &easypost.ShipmentOptions{
				AddressValidationLevel: "0",
			},
		},
	)

	fmt.Println(shipment)
}
