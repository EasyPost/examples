package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	reportOptions := &easypost.ListReportsOptions{
		PageSize: 5,
	}

	reports, _ := client.ListReports(
		"payment_log",
		reportOptions,
	)

	fmt.Println(reports)
}
