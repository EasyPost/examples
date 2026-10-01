package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func enable() {
	client := easypost.New("EASYPOST_API_KEY")

	apiKey, _ := client.EnableAPIKey("ak_...")

	fmt.Println(apiKey)
}
