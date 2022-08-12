package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	reportOptions := &easypost.ListReportsOptions{
        PageSize:  4,
        StartDate: "2016-01-02",
    }

    reports, err := client.ListReports(
        "payment_log",
        reportOptions,
    )

	fmt.Println(reports)
}
