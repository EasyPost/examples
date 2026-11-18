package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	accountLink, _ := client.CreateCustomerPortalAccountLink(
		&easypost.CustomerPortalAccountLinkParameters{
			SessionType: "account_management",
			UserID:      "user_...",
			RefreshURL:  "https://example.com/refresh",
			ReturnURL:   "https://example.com/return",
			Metadata: map[string]interface{}{
				"target": "wallet",
			},
		},
	)

	fmt.Println(accountLink)
}
