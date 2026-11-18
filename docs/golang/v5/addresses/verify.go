package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func verify() {
	client := easypost.New("EASYPOST_API_KEY")

	address, _ := client.VerifyAddress("adr_...")

	fmt.Println(address)
}
