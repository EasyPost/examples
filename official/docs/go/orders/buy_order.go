package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	order, _ := client.BuyOrder("order_...", "FeEx", "FEDEX_GROUND")

	fmt.Println(order)
}
