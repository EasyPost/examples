package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	address, err := client.CreateAndVerifyAddress(
        &easypost.Address{
            Street1: "417 Montgomery Street",
            Street2: "FL 5",
            City:    "San Francisco",
            State:   "CA",
            Zip:     "94104",
            Country: "US",
            Company: "EasyPost",
            Phone:   "415-123-4567",
        },
        &easypost.CreateAddressOptions{},
	)

	fmt.Println(address) 
}
