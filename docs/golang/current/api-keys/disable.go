package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func disable() {
	client := easypost.New("EASYPOST_API_KEY")

	apiKey, _ := client.DisableAPIKey("ak_...")

	fmt.Println(apiKey)
}
