package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	parcel, _ := client.CreateParcel(
		&easypost.Parcel{
			Length: 20.2,
			Width:  10.9,
			Height: 5,
			Weight: 65.9,
		},
	)

	fmt.Println(parcel)
}
