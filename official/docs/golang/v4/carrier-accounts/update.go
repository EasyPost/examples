package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func update() {
	client := easypost.New("EASYPOST_API_KEY")

	carrierAccount, _ := client.UpdateCarrierAccount(
		&easypost.CarrierAccount{
			ID:          "ca_...",
			Description: "FL Location DHL eCommerce Solutions Account",
			Credentials: map[string]string{
				"pickup_id": "abc123",
			},
		},
	)

	// For UPS account update, please use below method instead

	updateParameters := &easypost.UpsCarrierAccountUpdateParameters{
		AccountNumber: "987654321",
	}

	carrierAccount, _ = client.UpdateUpsCarrierAccount(carrierAccount.ID, updateParameters)

	fmt.Println(carrierAccount)
}
