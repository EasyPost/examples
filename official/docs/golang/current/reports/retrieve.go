package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	report, _ := client.GetReport("<REPORT_TYPE>", "<REPORT_ID>")

	fmt.Println(report)
}
