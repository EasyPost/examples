package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	childUsers, _ := client.ListChildUsers(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(childUsers)
}
