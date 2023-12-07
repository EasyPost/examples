package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	events, _ := client.ListEvents(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(events)
}
