package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func refund() {
	client := easypost.New("EASYPOST_API_KEY")

	insurance, _ := client.RefundInsurance("ins_...")

	fmt.Println(insurance)
}
