package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v6"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	paymentMethods, _ := client.RetrievePaymentMethods()

	fmt.Println(paymentMethods)
}
