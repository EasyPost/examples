package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func verifyParam() {
	client := easypost.New("EASYPOST_API_KEY")

	address, _ := client.CreateAddress(
		&easypost.Address{
			Street1: "000 unknown street",
			City:    "Not A City",
			State:   "ZZ",
			Zip:     "00001",
			Country: "US",
			Email:   "test@example.com",
			Phone:   "5555555555",
		},
		&easypost.CreateAddressOptions{
			Verify: true,
		},
	)

	fmt.Println(address)
}
