package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
	client := easypost.New(apiKey)

	referralCustomerCollection, _ := client.ListReferralCustomers(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	email := "email@example.com"
	user := referralCustomerCollection.ReferralCustomers[0]

	_, _ = client.UpdateReferralCustomerEmail(user.User.ID, email)
}
