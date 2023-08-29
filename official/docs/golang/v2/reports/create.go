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
		StartDate: "2022-10-01",
		EndDate:   "2022-10-31",
	}

	report, _ := client.CreateReport(
		"payment_log",
		reportOptions,
	)

	fmt.Println(report)
}
