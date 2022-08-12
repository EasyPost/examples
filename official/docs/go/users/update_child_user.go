package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	user, err := client.GetUser("user_...")
    name := "Test Child"

    user, err := client.UpdateUser(
        &easypost.UserOptions{
            Name: &name,
        },
    )

	fmt.Println(user)
}
