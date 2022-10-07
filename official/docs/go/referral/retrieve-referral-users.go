package example

import (
	"fmt"
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

	fmt.Println(referralCustomerCollection)
}
