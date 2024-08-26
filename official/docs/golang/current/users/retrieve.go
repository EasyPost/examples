package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	// Retrieve the authenticated user
	user, _ := client.RetrieveMe()
	fmt.Println(user)

	// Retrieve a child user
	user, _ = client.GetUser("user_...")
	fmt.Println(user)
}
