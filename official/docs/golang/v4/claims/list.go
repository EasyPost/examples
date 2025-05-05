package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func list() {
	client := easypost.New("EASYPOST_API_KEY")

	claims, _ := client.ListClaims(
		&easypost.ListClaimsParameters{
			PageSize: 5,
		},
	)

	fmt.Println(claims)
}
