package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	customsItem, _ := client.CreateCustomsItem(
		&easypost.CustomsItem{
			Description:   "T-shirts",
			Quantity:      1,
			Value:         10.00,
			Weight:        5,
			OriginCountry: "US",
		},
	)

	fmt.Println(customsItem)
}
