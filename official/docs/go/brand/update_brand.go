package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	user, _ := client.RetrieveMe()
	brand, _ := client.UpdateBrand(
		map[string]interface{}{
			"color": "#303F9F",
		},
		user.ID,
	)

	fmt.Println(brand)
}
