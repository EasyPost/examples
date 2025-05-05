package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func label() {
	client := easypost.New("EASYPOST_API_KEY")

	batch, _ := client.GetBatchLabels("batch_...", "PDF")

	fmt.Println(batch)
}
