package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	order, _ := client.GetOrder("order_...")

	fmt.Println(order)
}
