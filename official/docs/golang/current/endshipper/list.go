package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	endshippers, _ := client.ListEndShippers(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(endshippers)
}
