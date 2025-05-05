package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func addStripeCreditCard() {
	client := easypost.New("EASYPOST_API_KEY")

	creditCard, _ := client.AddReferralCustomerCreditCardFromStripe(
		"REFERRAL_USER_API_KEY",
		"seti_123",
		easypost.PrimaryPaymentMethodPriority,
	)

	fmt.Println(creditCard)
}
