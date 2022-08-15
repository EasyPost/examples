package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	scanForms, _ := client.ListScanForms(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(scanForms)
}
