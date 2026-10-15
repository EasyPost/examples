package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func brand() {
	client := easypost.New("EASYPOST_API_KEY")

	brand, _ := client.UpdateBrand(
		"user_...",
		map[string]interface{}{
			"color": "#303F9F",
		},
	)

	fmt.Println(brand)
}
