package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func delete() {
	client := easypost.New("EASYPOST_API_KEY")

	err := client.DeleteCarrierAccount("ca_...")

	fmt.Println(err)
}
