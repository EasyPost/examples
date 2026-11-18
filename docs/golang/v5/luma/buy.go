package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func buy() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	lumaRequest := &easypost.LumaRequest{
		Shipment:        easypost.Shipment{ID: shipment.ID},
		RulesetName:     "ruleset_...",
		PlannedShipDate: "2025-07-21",
		DeliverByDate:   "2025-07-25",
		PersistLabel:    false,
	}

	shipment, _ = client.BuyLumaShipment(shipment.ID, lumaRequest)

	fmt.Println(shipment)
}
