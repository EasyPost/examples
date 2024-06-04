package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	apiKey := os.Getenv("<YOUR_PRODUCTION_API_KEY>")
	client := easypost.New(apiKey)

	_, _ = client.RetrieveMe()
	rechargeThreshold := "50.00"

	_, _ = client.UpdateUser(
		&easypost.UserOptions{
			RechargeAmount: &rechargeThreshold,
		},
	)
}
