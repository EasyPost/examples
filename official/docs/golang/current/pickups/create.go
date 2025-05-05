package example

import (
	"fmt"
	"time"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	var minDatetime easypost.DateTime = easypost.DateTime(time.Now())
	var maxDatetime easypost.DateTime = easypost.DateTime(time.Now().Add(time.Hour * 24 * 7))

	pickup, _ := client.CreatePickup(
		&easypost.Pickup{
			IsAccountAddress: false,
			Address: &easypost.Address{
				ID: "adr_...",
			},
			Shipment: &easypost.Shipment{
				ID: "shp_...",
			},
			MinDatetime:  &minDatetime,
			MaxDatetime:  &maxDatetime,
			Instructions: "Special pickup instructions",
		},
	)

	fmt.Println(pickup)
}
