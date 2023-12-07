package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	toAddress, _ := client.GetAddress("shp_...")
	fromAddress, _ := client.GetAddress("adr_...")
	parcel, _ := client.GetParcel("prcl_...")

	shipment, _ := client.CreateShipment(
		&easypost.Shipment{
			ToAddress:   toAddress,
			FromAddress: fromAddress,
			Parcel:      parcel,
			Options: &easypost.ShipmentOptions{
				PrintCustom1: "Custom label message",
			},
		},
	)

	fmt.Println(shipment)
}
