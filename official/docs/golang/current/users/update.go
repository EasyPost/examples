package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	user, _ = client.UpdateUser(
		&easypost.UserOptions{
			ID:             "user_...",
			RechargeAmount: "50.00",
		},
	)

	fmt.Println(user)
}
