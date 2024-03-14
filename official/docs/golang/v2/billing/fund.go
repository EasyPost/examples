package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	fund := client.FundWallet("2000", easypost.PrimaryPaymentMethodPriority)

	fmt.Println(fund)
}
