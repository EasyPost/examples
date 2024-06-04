package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

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
