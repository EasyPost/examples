package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	reportOptions := &easypost.Report{
		StartDate: "2016-01-01",
		EndDate:   "2016-01-31",
	}

	report, _ := client.CreateReport(
		"shipment",
		reportOptions,
	)

	fmt.Println(report)
}
