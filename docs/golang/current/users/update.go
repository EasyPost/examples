package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func update() {
	client := easypost.New("EASYPOST_API_KEY")

	rechargeAmount := "50.00"

	user, _ := client.UpdateUser(
		&easypost.UserOptions{
			ID:             "user_...",
			RechargeAmount: &rechargeAmount,
		},
	)

	fmt.Println(user)
}
