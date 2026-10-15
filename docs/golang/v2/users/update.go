package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	user, _ := client.RetrieveMe()
	rechargeThreshold := "50.00"

	user, _ = client.UpdateUser(
		&easypost.UserOptions{
			RechargeAmount: &rechargeThreshold,
		},
	)

	fmt.Println(user)
}
