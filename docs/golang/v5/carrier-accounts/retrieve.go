package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	carrierAccount, _ := client.GetCarrierAccount("ca_...")

	fmt.Println(carrierAccount)
}
