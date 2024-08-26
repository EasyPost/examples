package example

import (
	"github.com/EasyPost/easypost-go/v4"
)

func configureRecharge() {
	client := easypost.New("EASYPOST_API_KEY")

	_, _ = client.RetrieveMe()
	rechargeThreshold := "50.00"

	_, _ = client.UpdateUser(
		&easypost.UserOptions{
			RechargeAmount: &rechargeThreshold,
		},
	)
}
