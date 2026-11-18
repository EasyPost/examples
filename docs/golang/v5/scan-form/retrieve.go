package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	scanForm, _ := client.GetScanForm("sf_...")

	fmt.Println(scanForm)
}
