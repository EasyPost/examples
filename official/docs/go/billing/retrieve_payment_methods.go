package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	paymentMethods, err := client.RetrievePaymentMethods()

	fmt.Println(paymentMethods) 
}
