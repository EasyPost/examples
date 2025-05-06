package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func update() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.UpdateWebhook(
		"hook_...",
		&easypost.CreateUpdateWebhookOptions{
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
