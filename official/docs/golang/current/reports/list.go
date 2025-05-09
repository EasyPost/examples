package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	reports, _ := client.ListReports(
		"payment_log",
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(reports)
}
