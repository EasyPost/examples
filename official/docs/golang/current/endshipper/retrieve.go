package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	retrievedEndShipper, _ := client.GetEndShipper("es_...")

	fmt.Println(retrievedEndShipper)
}
