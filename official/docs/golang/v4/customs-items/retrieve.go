package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	customsItem, _ := client.GetCustomsItem("cstitem_...")

	fmt.Println(customsItem)
}
