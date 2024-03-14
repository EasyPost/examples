package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	address, _ := client.CreateAndVerifyAddress(
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
