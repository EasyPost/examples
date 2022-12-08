package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

    referralUserApiKey := os.Getenv("REFERRAL_USER_API_KEY")

	creditCard, _ := client.AddReferralCustomerCreditCard(referralUserApiKey, &easypost.CreditCardOptions{
        Number:  "0123456789101234",
        ExpMonth:  "01",
        ExpYear: "2028",
        Cvc: "111",
    }, easypost.PrimaryPaymentMethodPriority)

	fmt.Println(creditCard)
}
