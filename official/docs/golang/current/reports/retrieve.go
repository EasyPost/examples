package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	report, _ := client.GetReport("<REPORT_TYPE>", "<REPORT_ID>")

	fmt.Println(report)
}
