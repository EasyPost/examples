package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	payloads, _ := client.ListEventPayloads("evt_...")

	fmt.Println(payloads)
}
