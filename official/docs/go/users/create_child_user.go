package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	userName := "Child Account Name"
    user, err := client.CreateUser(
        &easypost.UserOptions{
            Name: &userName,
        },
    )

	fmt.Println(user)
}
