package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	event, _ := client.GetEvent("evt_...")

	fmt.Println(event)
}
