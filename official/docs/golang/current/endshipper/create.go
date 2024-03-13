package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	endshipper, _ := client.CreateEndShipper(
		&easypost.Address{
			Name:    "FOO BAR",
			Company: "BAZ",
			Street1: "164 TOWNSEND STREET UNIT 1",
			Street2: "UNIT 1",
			City:    "SAN FRANCISCO",
			State:   "CA",
			Zip:     "94107",
			Country: "US",
			Phone:   "555-555-5555",
			Email:   "FOO@EXAMPLE.COM",
		},
	)

	fmt.Println(endshipper)
}
