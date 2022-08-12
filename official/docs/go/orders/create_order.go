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
	shipment, err := client.CreateShipment(
        &easypost.Shipment{
            Parcel: &easypost.Parcel{
				Weight: 10.2,
			},
			Parcel: &easypost.Parcel{
				Weight: 17.5,
				PredefinedPackage: "FedExBox",
			}
        },
    )
    order, err := client.CreateOrder(
        &easypost.Order{
            ToAddress:   toAddress,
            FromAddress: fromAddress,
            Shipments: []*easypost.Shipment{
              shipment,
            },
        },
    )

	fmt.Println(order)
}
