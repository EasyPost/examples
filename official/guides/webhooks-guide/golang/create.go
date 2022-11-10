package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    _, _ = client.CreateWebhookWithDetails(
		&easypost.CreateUpdateWebhookOptions{
			URL: "https://example.com",
			WebhookSecret: "A1B2C3",
		},
	)
}
