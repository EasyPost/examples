package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

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
