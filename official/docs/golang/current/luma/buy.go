package example

import (
	"fmt"
	"github.com/EasyPost/easypost-go/v5"
)

func buy() {
	client := easypost.New("EASYPOST_API_KEY")
	
	shipment, _ := client.BuyLumaShipment("shp_...", map[string]any{
		"ruleset_name":       "ruleset_name",
		"planned_ship_date":  "2025-07-01",
		"deliver_by_date":    "2025-07-03",
	})

	fmt.Println(shipment)
}
