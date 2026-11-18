package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func createWithOptions() {
	client := easypost.New("EASYPOST_API_KEY")

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
