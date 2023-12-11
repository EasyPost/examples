package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	carrierAccount, _ := client.GetCarrierAccount("ca_...")

	carrierAccount, _ = client.UpdateCarrierAccount(
		&easypost.CarrierAccount{
			ID:          carrierAccount.ID,
			Description: "FL Location DHL eCommerce Solutions Account",
			Credentials: map[string]string{
				"pickup_id": "abc123",
			},
		},
	)

	fmt.Println(carrierAccount)
}
