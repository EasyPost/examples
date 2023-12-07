package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")

	firstShipment := &easypost.Shipment{
		Parcel: &easypost.Parcel{
			PredefinedPackage: "FedExBox",
			Weight:            10.4,
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
