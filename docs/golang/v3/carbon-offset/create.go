package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.CreateShipmentWithCarbonOffset(
		&easypost.Shipment{
			ToAddress: &easypost.Address{
				Name:    "Dr. Steve Brule",
				Street1: "179 N Harbor Dr",
				City:    "Redondo Beach",
				State:   "CA",
				Zip:     "90277",
				Country: "US",
				Phone:   "4155559999",
				Email:   "dr_steve_brule@gmail.com",
			},
			FromAddress: &easypost.Address{
				Name:    "EasyPost",
				Street1: "417 Montgomery Street",
				Street2: "5th Floor",
				City:    "San Francisco",
				State:   "CA",
				Zip:     "90277",
				Country: "US",
				Phone:   "4155559999",
				Email:   "support@easypost.com",
			},
			Parcel: &easypost.Parcel{
				Length: 20.2,
				Width:  10.9,
				Height: 5,
				Weight: 65.9,
			},
		},
	)

	fmt.Println(shipment)
}
