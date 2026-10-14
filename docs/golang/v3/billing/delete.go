package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	err := client.DeletePaymentMethod(easypost.PrimaryPaymentMethodPriority)

	fmt.Println(err)
}
