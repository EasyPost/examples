package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	paymentMethod, _ := client.BetaAddPaymentMethod("cus_...", "ba_...", easypost.PrimaryPaymentMethodPriority)

	fmt.Println(paymentMethod)
}
