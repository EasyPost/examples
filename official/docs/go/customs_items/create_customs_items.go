package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	customsItem, err := client.CreateCustomsItem(
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
