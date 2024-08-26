package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func brand() {
	client := easypost.New("EASYPOST_API_KEY")

	brand, _ := client.UpdateBrand(
		map[string]interface{}{
			"color": "#303F9F",
		},
		"user_...",
	)

	fmt.Println(brand)
}
