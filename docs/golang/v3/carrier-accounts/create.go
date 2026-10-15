package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
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
}
