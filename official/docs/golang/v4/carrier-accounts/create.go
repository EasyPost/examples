package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	carrierAccount, _ := client.CreateCarrierAccount(
		&easypost.CarrierAccount{
			Type:        "DhlEcsAccount",
			Description: "CA Location DHL eCommerce Solutions Account",
			Credentials: map[string]string{
				"client_id":           "123456",
				"client_secret":       "123abc",
				"distribution_center": "USLAX1",
				"pickup_id":           "123456",
			},
			TestCredentials: map[string]string{
				"client_id":           "123456",
				"client_secret":       "123abc",
				"distribution_center": "USLAX1",
				"pickup_id":           "123456",
			},
		},
	)

	fmt.Println(carrierAccount)

	// For UPS account creation, please use below method instead

	createUpsParameters := &easypost.UpsCarrierAccountCreationParameters{
		AccountNumber: "123456789",
		Type:          "UpsAccount",
	}

	carrierAccount, _ = client.CreateUpsCarrierAccount(createUpsParameters)

	fmt.Println(carrierAccount)
}
