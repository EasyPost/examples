package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func buy() {
	client := easypost.New("EASYPOST_API_KEY")

	rate := &easypost.PickupRate{Carrier: "UPS", Service: "Same-day Pickup"}
	pickup, _ := client.BuyPickup("pickup...", rate)

	fmt.Println(pickup)
}
