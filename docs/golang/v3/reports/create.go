package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

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
