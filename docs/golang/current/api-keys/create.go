package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	apiKey, _ := client.CreateAPIKey("test")

	fmt.Println(apiKey)
}
