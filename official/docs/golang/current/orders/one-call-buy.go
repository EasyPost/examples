package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func oneCallBuy() {
	client := easypost.New("EASYPOST_API_KEY")

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")
	firstShipment := &easypost.Shipment{
		Parcel: &easypost.Parcel{
			Weight: 10.2,
		},
	}
	secondShipment := &easypost.Shipment{
		Parcel: &easypost.Parcel{
			PredefinedPackage: "FedExBox",
			Weight:            17.5,
		},
	}

	order, _ := client.CreateOrder(
		&easypost.Order{
			Service:     "NextDayAir",
			ToAddress:   toAddress,
			FromAddress: fromAddress,
			Shipments: []*easypost.Shipment{
				firstShipment,
				secondShipment,
			},
		},
		&easypost.CarrierAccount{
			ID: "ca_...",
		},
	)

	fmt.Println(order)
}
