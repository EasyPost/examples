package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	refunds, _ := client.CreateRefund(
		map[string]interface{}{
			"carrier":        "USPS",
			"tracking_codes": []string{"EZ1000000001"},
		},
	)

	fmt.Println(refunds)
}
