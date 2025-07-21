package example

import (
  "fmt"

  "github.com/EasyPost/easypost-go/v5"
)

func buyLuma() {
  client := easypost.New("EASYPOST_API_KEY")

  params := map[string]interface{}{
    "ruleset_name":      "required_deliver_by_date",
    "planned_ship_date": "2025-05-14",
    "deliver_by_date":   "2025-05-16",
  }

  shipment, _ := client.BuyLumaShipment("shp_...", params)

  fmt.Println(shipment)
}
