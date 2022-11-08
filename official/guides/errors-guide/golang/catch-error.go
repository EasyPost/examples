package example

import (
    "fmt"
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    address, err := client.CreateAddress(
        &easypost.Address{
            ...
        },
        &easypost.CreateAddressOptions{
            VerifyStrict: []string{"true"},
        },
    )

    fmt.Println(err)

}
