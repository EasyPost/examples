package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	userName := "Child Account Name"
	user, _ := client.CreateUser(
		&easypost.UserOptions{
			Name: &userName,
		},
	)

	fmt.Println(user)
}
