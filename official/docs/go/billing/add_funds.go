package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	fund := client.FundWallet("2000", easypost.PrimaryPaymentMethodPriority)

	fmt.Println(fund) 
}
