package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	parcel, _ := client.GetParcel("prcl_...")

	fmt.Println(parcel)
}
