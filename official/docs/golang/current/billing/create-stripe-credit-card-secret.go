package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func createStripeCreditCardSecret() {
	client := easypost.New("EASYPOST_API_KEY")

	response, _ := client.BetaCreateCreditCardClientSecret()

	fmt.Println(response)
}
