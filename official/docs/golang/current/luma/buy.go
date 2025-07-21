package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func buyLuma() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.GetShipment("shp_...")
	shipment, _ = client.BuyLumaShipment(
		shipment.ID,
		&easypost.LumaShipmentOptions{
			RulesetName:     "required_deliver_by_date",
			PlannedShipDate: "2025-07-21",
			DeliverByDate:   "2025-07-23",
		},
	)

	fmt.Println(shipment)
}
