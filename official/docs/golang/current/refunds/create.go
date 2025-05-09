package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	refunds, _ := client.CreateRefund(
		map[string]interface{}{
			"carrier":        "USPS",
			"tracking_codes": []string{"EZ1000000001"},
		},
	)

	fmt.Println(refunds)
}
