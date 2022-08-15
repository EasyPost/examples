package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	rate := &easypost.PickupRate{Carrier: "UPS", Service: "Same-day Pickup"}
	pickup, _ := client.BuyPickup("pickup...", rate)

	fmt.Println(pickup)
}
