package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	parcel, err := client.CreateParcel(
        &easypost.Parcel{
            Length: 20.2,
            Width:  10.9,
            Height: 5,
            Weight: 65.9,
        },
    )

	fmt.Println(parcel)
}
