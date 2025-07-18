package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func oneCallBuyLuma() {
	client := easypost.New("EASYPOST_API_KEY")
	
	shipment, _ := client.CreateAndBuyLumaShipment(&easypost.LumaRequest{
		Shipment: easypost.Shipment{
			ToAddress: &easypost.Address{
				Name:    "Dr. Steve Brule",
				Street1: "5744 Silverton Ave",
				City:    "McKinney",
				State:   "TX",
				Zip:     "75070",
				Country: "US",
				Phone:   "8573875756",
				Email:   "dr_steve_brule@gmail.com",
			},
			FromAddress: &easypost.Address{
				Name:    "EasyPost",
				Street1: "417 Montgomery Street",
				Street2: "5th Floor",
				City:    "San Francisco",
				State:   "CA",
				Zip:     "94104",
				Country: "US",
				Phone:   "4153334445",
				Email:   "support@easypost.com",
			},
			Parcel: &easypost.Parcel{
				Length: 20.2,
				Width:  10.9,
				Height: 5,
				Weight: 65.9,
			},
			CarrierAccountIDs: []string{"ca_..."},
		},
		RulesetName:     "required_deliver_by_date",
		PlannedShipDate: "2025-07-18",
		DeliverByDate:   "2025-07-20",
	})

	fmt.Println(shipment)
}
