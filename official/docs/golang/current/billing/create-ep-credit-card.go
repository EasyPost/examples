package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	creditCard, _ := client.AddReferralCustomerCreditCard("REFERRAL_USER_API_KEY", &easypost.CreditCardOptions{
		Number:   "0123456789101234",
		ExpMonth: "01",
		ExpYear:  "2025",
		Cvc:      "111",
	}, easypost.PrimaryPaymentMethodPriority)

	fmt.Println(creditCard)
}
