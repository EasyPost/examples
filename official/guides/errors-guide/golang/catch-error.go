package example

import (
    "fmt"
    "github.com/EasyPost/easypost-go/v4"
)

func main() {
    client := easypost.New("EASYPOST_API_KEY")

    _, err := client.CreateAddress(
        &easypost.Address{
            // address params here
        },
        &easypost.CreateAddressOptions{
            VerifyStrict: []string{"true"},
        },
    )

    if err, ok := err.(*easypost.APIError); ok {
        fmt.Println(err.Code)
    }
}
