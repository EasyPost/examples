package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieveStripePublicKey() {
	client := easypost.New("EASYPOST_API_KEY")

	response, _ := client.RetrieveEasypostStripeApiKey()

	fmt.Println(response)
}
