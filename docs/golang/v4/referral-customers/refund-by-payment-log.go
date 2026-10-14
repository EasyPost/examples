package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func refundByPaymentLog() {
	client := easypost.New("EASYPOST_API_KEY")

	refund, _ := client.BetaRefundByPaymentLog("paylog_...")

	fmt.Println(refund)
}
