package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	user, _ := client.RetrieveMe()
	brand, _ := client.UpdateBrand(
		map[string]interface{}{
			"color": "#303F9F",
		},
		user.ID,
	)

	fmt.Println(brand)
}
