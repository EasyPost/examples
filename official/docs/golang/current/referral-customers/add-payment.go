package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	paymentMethod, _ := client.BetaAddPaymentMethod("cus_123", "ba_123")

	fmt.Println(paymentMethod)
}
