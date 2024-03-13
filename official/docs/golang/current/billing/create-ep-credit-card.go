package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	referralUserApiKey := os.Getenv("REFERRAL_USER_API_KEY")

	creditCard, _ := client.AddReferralCustomerCreditCard(referralUserApiKey, &easypost.CreditCardOptions{
		Number:   "0123456789101234",
		ExpMonth: "01",
		ExpYear:  "2025",
		Cvc:      "111",
	}, easypost.PrimaryPaymentMethodPriority)

	fmt.Println(creditCard)
}
