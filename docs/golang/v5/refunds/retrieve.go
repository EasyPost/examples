package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	refund, _ := client.GetRefund("shp_...")

	fmt.Println(refund)
}
