package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	// Retrieve all API keys including children
	apiKeys, _ := client.GetAPIKeys()

	fmt.Println(apiKeys)

	// Retrieve API keys for a specific child user
	childApiKeys, _ := client.GetAPIKeysForUser("user_...")

	fmt.Println(childApiKeys)
}
