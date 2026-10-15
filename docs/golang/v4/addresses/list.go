package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	addresses, _ := client.ListAddresses(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(addresses)
}
