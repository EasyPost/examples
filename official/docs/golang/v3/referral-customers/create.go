package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	name := "Test Referral"
	email := "test@example.com"
	phone := "5555555555"

	referralUser, _ := client.CreateReferralCustomer(
		&easypost.UserOptions{
			Name:  &name,
			Email: &email,
			Phone: &phone,
		},
	)

	fmt.Println(referralUser)
}
