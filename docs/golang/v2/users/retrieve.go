package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	// Retrieve the authenticated user
	user, _ := client.RetrieveMe()

	// Retrieve a child user
	user, _ = client.GetUser("user_...")

	fmt.Println(user)
}
