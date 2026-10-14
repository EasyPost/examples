package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	paymentMethod, _ := client.BetaAddPaymentMethod("cus_...", "card_...", easypost.PrimaryPaymentMethodPriority)

	fmt.Println(paymentMethod)
}
