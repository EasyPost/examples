package example

import (
  "fmt"

  "github.com/EasyPost/easypost-go/v5"
)

func lumaPromise() {
  client := easypost.New("EASYPOST_API_KEY")

  params := map[string]interface{
    "shipment": map[string]interface{
      "to_address": map[string]interface{
        "name":    "Dr. Steve Brule",
        "street1": "5744 Silverton Ave",
        "city":    "McKinney",
        "state":   "TX",
        "zip":     "75070",
        "country": "US",
        "phone":   "8573875756",
        "email":   "dr_steve_brule@gmail.com",
      },
      "from_address": map[string]interface{
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
      "parcel": map[string]interface{
        "length": 20.2,
        "width":  10.9,
        "height": 5.0,
        "weight": 65.9,
      },
      "ruleset_name":       "test_ruleset_deliver_by_2",
      "planned_ship_date":  "2025-07-21",
      "deliver_by_date":    "2025-07-23",
    },
  }

  promise, _ := client.Shipment.GetLumaPromise(params)

  fmt.Println(promise)
}
