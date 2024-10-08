package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.CreateWebhookWithDetails(
		&easypost.CreateUpdateWebhookOptions{
			URL:           "example.com",
			WebhookSecret: "A1B2C3",
		},
	)

	fmt.Println(webhook)
}
