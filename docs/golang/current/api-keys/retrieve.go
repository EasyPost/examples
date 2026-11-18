package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	// Retrieve all API keys including children
	apiKeys, _ := client.GetAPIKeys()

	fmt.Println(apiKeys)

	// Retrieve API keys for a specific child user
	childAPIKeys, _ := client.GetAPIKeysForUser("user_...")

	fmt.Println(childAPIKeys)
}
