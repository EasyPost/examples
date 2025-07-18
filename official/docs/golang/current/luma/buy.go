package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func buyLuma() {
	client := easypost.New("EASYPOST_API_KEY")

	params := &easypost.LumaRequest{
		RulesetName:     "required_deliver_by_date",
		PlannedShipDate: "2025-05-14",
		DeliverByDate:   "2025-05-16",
	}

	shipment, _ := client.BuyLumaShipment("shp_...", params)

	fmt.Println(shipment)
}
