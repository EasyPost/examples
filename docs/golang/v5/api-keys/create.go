package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	apiKey, _ := client.CreateAPIKey("test")

	fmt.Println(apiKey)
}
