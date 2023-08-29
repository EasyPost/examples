package example

import (
	"fmt"
	"github.com/EasyPost/easypost-go/v3"
	"os"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	pickups, _ := client.ListPickups(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(pickups)
}
