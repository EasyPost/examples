package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func update() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.UpdateWebhook(
		"hook_...",
		&easypost.CreateUpdateWebhookOptions{},
	)

	fmt.Println(webhook)
}
