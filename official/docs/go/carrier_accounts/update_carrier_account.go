package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	carrierAccount, err := client.GetCarrierAccount("ca_...")

    carrierAccount.Credentials = map[string]string{
        "pickup_id": "abc123",
    }
    carrierAccount, err := client.UpdateCarrierAccount(
        carrierAccount,
    )

	fmt.Println(carrierAccount) 
}
