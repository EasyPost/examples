package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func retrieveStripePublicKey() {
	client := easypost.New("EASYPOST_API_KEY")

	response, _ := client.RetrieveEasypostStripeAPIKey()

	fmt.Println(response)
}
