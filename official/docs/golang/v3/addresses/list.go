package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	addresses, _ := client.ListAddresses(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(addresses)
}
