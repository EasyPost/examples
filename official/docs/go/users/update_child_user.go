package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	user, _ := client.GetUser("user_...")
	name := "Test Child"

	user, _ = client.UpdateUser(
		&easypost.UserOptions{
			Name: &name,
		},
	)

	fmt.Println(user)
}
