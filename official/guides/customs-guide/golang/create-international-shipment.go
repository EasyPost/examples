package example

import (
	"fmt"
	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.CreateShipment(
		&easypost.Shipment{
			FromAddress: &easypost.Address{
				Company: "EasyPost",
				Street1: "417 Montgomery Street",
				Street2: "5th Floor",
				City:    "San Francisco",
				State:   "CA",
				Country: "US",
				Zip:     "94104",
			},
			ToAddress: &easypost.Address{
				Name:    "Tim Canterbury",
				Company: "Wernham Hogg",
				Street1: "118 Clippenham Lane",
				City:    "Slough",
				Country: "GB",
				Zip:     "SL15BE",
			},
			Parcel: &easypost.Parcel{
				Length: 9,
				Width:  6,
				Height: 3,
				Weight: 20,
			},
			CustomsInfo: &easypost.CustomsInfo{
				EELPFC:              "NOEEI 30.37(a)",
				CustomsCertify:      true,
				CustomsSigner:       "Steve Brule",
				ContentsType:        "merchandise",
				ContentsExplanation: "",
				RestrictionType:     "none",
				CustomsItems: []*easypost.CustomsItem{
					&easypost.CustomsItem{
						Description:    "T-shirt",
						Quantity:       2,
						Value:          23,
						Weight:         11,
						HSTariffNumber: "654321",
						OriginCountry:  "US",
					},
				},
			},
		},
	)

	fmt.Println(shipment)
}
