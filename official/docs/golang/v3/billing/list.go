package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	paymentMethods, _ := client.RetrievePaymentMethods()

	fmt.Println(paymentMethods)
}
