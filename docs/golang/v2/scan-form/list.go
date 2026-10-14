package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	scanForms, _ := client.ListScanForms(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(scanForms)
}
