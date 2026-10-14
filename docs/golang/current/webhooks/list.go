package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	webhooks, _ := client.ListWebhooks()

	fmt.Println(webhooks)
}
