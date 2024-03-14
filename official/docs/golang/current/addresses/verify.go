package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	address, _ := client.CreateAddress(
		&easypost.Address{
			Street1: "417 MONTGOMERY ST",
			Street2: "FLOOR 5",
			City:    "SAN FRANCISCO",
			State:   "CA",
			Zip:     "94104",
			Country: "US",
			Company: "EasyPost",
			Phone:   "415-123-4567",
		},
		&easypost.CreateAddressOptions{},
	)

	verifiedAddress, _ := client.VerifyAddress(address.ID)

	fmt.Println(verifiedAddress)
}
