package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func buy() {
	client := easypost.New("EASYPOST_API_KEY")

	order, _ := client.BuyOrder("order_...", "FedEx", "FEDEX_GROUND")

	fmt.Println(order)
}
