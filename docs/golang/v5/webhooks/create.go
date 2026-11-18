package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.CreateWebhook(
		&easypost.CreateUpdateWebhookOptions{
			URL:           "example.com",
			WebhookSecret: "A1B2C3",
			CustomHeaders: []easypost.WebhookCustomHeader{
				{
					Name:  "X-Header-Name",
					Value: "header_value",
				},
			},
		},
	)

	fmt.Println(webhook)
}
