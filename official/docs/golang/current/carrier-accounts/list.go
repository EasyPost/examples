package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	carrierAccounts, _ := client.ListCarrierAccounts()

	fmt.Println(carrierAccounts)
}
