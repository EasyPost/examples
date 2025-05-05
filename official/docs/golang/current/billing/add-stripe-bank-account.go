package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func addStripeBankAccount() {
	client := easypost.New("EASYPOST_API_KEY")

	bankAccount, _ := client.AddReferralCustomerBankAccountFromStripe(
		"REFERRAL_USER_API_KEY",
		"fca_...",
		&easypost.MandateData{
			IpAddress:  "127.0.0.1",
			UserAgent:  "Mozilla/5.0",
			AcceptedAt: 1722510730,
		},
		easypost.PrimaryPaymentMethodPriority,
	)

	fmt.Println(bankAccount)
}
