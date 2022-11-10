package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    fromAddress, err := client.CreateAddress(
        &easypost.Address{
            Company: "EasyPost",
            Street1: "417 Montgomery Street",
            Street2: "5th Floor",
            City:    "San Francisco",
            State:   "CA",
            Zip:     "94104",
            Phone:   "415-528-7555",
        },
        &easypost.CreateAddressOptions{},
    )
}
