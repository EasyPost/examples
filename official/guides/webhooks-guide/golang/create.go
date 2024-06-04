package example

import (
    "github.com/EasyPost/easypost-go/v4"
)

func main() {
    client := easypost.New("EASYPOST_API_KEY")

    _, _ = client.CreateWebhookWithDetails(
		&easypost.CreateUpdateWebhookOptions{
			URL: "https://example.com",
			WebhookSecret: "A1B2C3",
		},
	)
}
