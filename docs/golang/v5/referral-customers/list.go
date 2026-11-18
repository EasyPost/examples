package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	referralCustomerCollection, _ := client.ListReferralCustomers(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(referralCustomerCollection)
}
