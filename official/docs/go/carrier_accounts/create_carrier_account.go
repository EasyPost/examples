package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	carrierAccount, err := client.CreateCarrierAccount(
        &easypost.CarrierAccount{
            Type:        "DhlEcsAccount",
            Description: "CA Location DHL eCommerce Solutions Account",
            Credentials: map[string]string{
                "client_id": "123456",
                "client_secret": "123abc",
                "distribution_center": "USLAX1",
                "pickup_id": "123456"
            },
            TestCredentials: map[string]string{
                "client_id": "123456",
                "client_secret": "123abc",
                "distribution_center": "USLAX1",
                "pickup_id": "123456"
            },
        },
    )

	fmt.Println(carrierAccount) 
}
