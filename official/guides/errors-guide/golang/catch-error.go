package example

import (
	"errors"
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

	var eperr *easypost.APIError
	if errors.As(err, &eperr) {
		fmt.Println(eperr.Code)
	}
}
