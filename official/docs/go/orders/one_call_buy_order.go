package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	toAddress, err := client.GetAddress("adr_...")
    fromAddress, err := client.GetAddress("adr_...")

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

    order, err := client.CreateOrder(
        &easypost.Order{
            Service: "NextDayAir",
            ToAddress: ...,
            FromAddress: ...,
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
