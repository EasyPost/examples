package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func refundByAmount() {
	client := easypost.New("EASYPOST_API_KEY")

	refund, _ := client.BetaRefundByAmount(2000)

	fmt.Println(refund)
}
