package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	parcel, _ := client.GetParcel("prcl_...")

	fmt.Println(parcel)
}
