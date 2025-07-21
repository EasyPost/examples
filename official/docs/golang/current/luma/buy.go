package example

import (
  "fmt"

  "github.com/EasyPost/easypost-go/v5"
)

func buyLuma() {
  client := easypost.New("EASYPOST_API_KEY")

  params := map[string]any{
    "ruleset_name":      "required_deliver_by_date",
    "planned_ship_date": "2025-07-21",
    "deliver_by_date":   "2025-07-23",
  }

  shipment, _ := client.Shipment.BuyLuma("shp_...", params)

  fmt.Println(shipment)
}
