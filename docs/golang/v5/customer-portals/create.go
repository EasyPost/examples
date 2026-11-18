package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	accountLink, _ := client.CreateCustomerPortalAccountLink(
		&easypost.CustomerPortalAccountLinkParameters{
			SessionType: "account_management",
			UserId:      "user_...",
			RefreshUrl:  "https://example.com/refresh",
			ReturnUrl:   "https://example.com/return",
			Metadata: map[string]interface{}{
				"target": "wallet",
			},
		},
	)

	fmt.Println(accountLink)
}
