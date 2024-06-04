package example

import (
	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	client.FundWallet("2000", easypost.PrimaryPaymentMethodPriority)
}
