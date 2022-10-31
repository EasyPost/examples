package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	// Retrieve the authenticated user
	user, _ := client.RetrieveMe()

	// Retrieve a child user
	user, _ := client.GetUser("user_...")

	fmt.Println(user)
}
