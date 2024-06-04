package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	apiKey := os.Getenv("YOUR_PRODUCTION_API_KEY")
	client := easypost.New(apiKey)

	_ = client.FundWallet("2000", easypost.PrimaryPaymentMethodPriority)
}
