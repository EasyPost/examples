package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func scanForms() {
	client := easypost.New("EASYPOST_API_KEY")

	batch, _ := client.CreateBatchScanForms("batch_...", "pdf")

	fmt.Println(batch)
}
