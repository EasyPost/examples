package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	address, _ := client.CreateAddress(&easypost.Address{}, &easypost.CreateAddressOptions{})

	parcel, _ := client.CreateParcel(
		&easypost.Parcel{
			PredefinedPackage: "Parcel",
			Weight:            28,
		},
	)

	shipment, _ := client.CreateShipment(
		&easypost.Shipment{
			ToAddress:   address,
			FromAddress: address,
			Parcel:      parcel,
		},
	)

	client.BuyShipment(shipment.ID, shipment.Rates[0], "")
}
