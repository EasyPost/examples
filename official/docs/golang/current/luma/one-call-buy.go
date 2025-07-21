package example

import (
  "fmt"

  "github.com/EasyPost/easypost-go/v5"
)

func oneCallBuyLuma() {
  client := easypost.New("EASYPOST_API_KEY")

  params := map[string]any{
    "to_address": map[string]any{
      "name":    "Dr. Steve Brule",
      "street1": "5744 Silverton Ave",
      "city":    "McKinney",
      "state":   "TX",
      "zip":     "75070",
      "country": "US",
      "phone":   "8573875756",
      "email":   "dr_steve_brule@gmail.com",
    },
    "from_address": map[string]any{
      "name":    "EasyPost",
      "street1": "417 Montgomery Street",
      "street2": "5th Floor",
      "city":    "San Francisco",
      "state":   "CA",
      "zip":     "94104",
      "country": "US",
      "phone":   "4153334445",
      "email":   "support@easypost.com",
    },
    "parcel": map[string]any{
      "length": 20.2,
      "width":  10.9,
      "height": 5.0,
      "weight": 65.9,
    },
    "carrier_accounts":  []string{"ca_..."},
    "persist_label":      true,
    "ruleset_name":       "required_deliver_by_date",
    "planned_ship_date":  "2025-07-21",
    "deliver_by_date":    "2025-07-23",
    "insurance":          "50.00",
  }

  shipment, _ := client.Shipment.CreateAndBuyLuma(params)

  fmt.Println(shipment)
}
