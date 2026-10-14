package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	payload, _ := client.GetEventPayload("evt_...", "payload_...")

	fmt.Println(payload)
}
