package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	scanForm, _ := client.CreateScanForm("shp_...", "shp_...")

	fmt.Println(scanForm)
}
