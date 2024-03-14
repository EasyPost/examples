package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	webhook, _ := client.CreateWebhook("example.com")

	fmt.Println(webhook)
}
