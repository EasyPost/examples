package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.GetWebhook("hook_...")

	fmt.Println(webhook)
}
