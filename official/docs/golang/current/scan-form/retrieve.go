package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	scanForm, _ := client.GetScanForm("sf_...")

	fmt.Println(scanForm)
}
