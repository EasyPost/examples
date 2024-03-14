package example

import (
	"fmt"
	"time"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	address, _ := client.GetAddress("adr_...")
	shipment, _ := client.GetShipment("shp_...")
	minPickupTime := time.Now()                         // now
	maxPickupTime := time.Now().Add(time.Hour * 24 * 7) // 7 days from now

	pickup, _ := client.CreatePickup(
		&easypost.Pickup{
			IsAccountAddress: false,
			Address:          address,
			Shipment:         shipment,
			MinDatetime:      &minPickupTime,
			MaxDatetime:      &maxPickupTime,
			Instructions:     "Special pickup instructions",
		},
	)

	fmt.Println(pickup)
}
