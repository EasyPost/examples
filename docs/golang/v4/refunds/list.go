package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	refunds, _ := client.ListRefunds(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(refunds)
}
