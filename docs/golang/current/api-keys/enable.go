package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func enable() {
	client := easypost.New("EASYPOST_API_KEY")

	apiKey, _ := client.EnableAPIKey("ak_...")

	fmt.Println(apiKey)
}
