package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	carrierAccount, _ := client.GetCarrierAccount("ca_...")

	carrierAccount, _ = client.UpdateCarrierAccount(
		&easypost.CarrierAccount{
			ID: carrierAccount.ID,
			Credentials: map[string]string{
				"pickup_id": "abc123",
			},
		},
	)

	fmt.Println(carrierAccount)
}
