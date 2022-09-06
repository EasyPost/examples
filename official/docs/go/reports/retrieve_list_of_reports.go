package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	reportOptions := &easypost.ListReportsOptions{
		PageSize:  5,
		StartDate: "2022-10-01",
	}

	reports, _ := client.ListReports(
		"payment_log",
		reportOptions,
	)

	fmt.Println(reports)
}
