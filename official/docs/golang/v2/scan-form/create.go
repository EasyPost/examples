package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	scanForm, _ := client.CreateScanForm("shp_...", "shp_...")

	fmt.Println(scanForm)
}
