package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	address, _ := client.CreateAddress(
		&easypost.Address{
			Street1: "UNDELIVERABLE ST",
			City:    "SAN FRANCISCO",
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
