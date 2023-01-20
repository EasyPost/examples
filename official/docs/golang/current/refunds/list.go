package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	refunds, _ := client.ListRefunds(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(refunds)
}
