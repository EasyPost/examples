package luma

import (
	"fmt"
	"github.com/EasyPost/easypost-go/v5"
)

func Promise() {
	client := easypost.New("EASYPOST_API_KEY")
	params := map[string]interface{}{
		"to_address": map[string]interface{}{
			"name":    "Dr. Steve Brule",
			"street1": "179 N Harbor Dr",
			"city":    "Redondo Beach",
			"state":   "CA",
			"zip":     "90277",
			"country": "US",
			"phone":   "4155559999",
			"email":   "dr_steve_brule@gmail.com",
		},
		"from_address": map[string]interface{}{
			"name":    "EasyPost",
			"street1": "417 Montgomery Street",
			"street2": "5th Floor",
			"city":    "San Francisco",
			"state":   "CA",
			"zip":     "94104",
			"country": "US",
			"phone":   "4155559999",
			"email":   "support@easypost.com",
		},
		"parcel": map[string]interface{}{
			"length": 20.2,
			"width":  10.9,
			"height": 5,
			"weight": 65.9,
		},
		"ruleset_name":       "my_ruleset",
		"planned_ship_date":  "2025-07-01",
		"deliver_by_date":    "2025-07-06",
	}
	
	response, err := client.Do("POST", "/v2/luma/promise", params)
	if err != nil {
		panic(err)
	}
	fmt.Println(response)
}
