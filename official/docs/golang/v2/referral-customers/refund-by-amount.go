package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	refund, _ := client.BetaRefundByAmount(2000)

	fmt.Println(refund)
}
