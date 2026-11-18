package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")
	parcel, _ := client.GetParcel("prcl_...")

	shipment, _ := client.CreateShipment(
		&easypost.Shipment{
			ToAddress:   toAddress,
			FromAddress: fromAddress,
			Parcel:      parcel,
			TaxIdentifiers: []*easypost.TaxIdentifier{
				&easypost.TaxIdentifier{
					Entity:         "SENDER",
					TaxID:          "GB123456789",
					IssuingCountry: "GB",
					TaxIDType:      "EORI",
				},
			},
		},
	)

	fmt.Println(shipment)
}
