package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.GetWebhook("hook_...")

	fmt.Println(webhook)
}
