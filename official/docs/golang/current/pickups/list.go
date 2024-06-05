package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	pickups, _ := client.ListPickups(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(pickups)
}
