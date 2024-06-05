package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

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
