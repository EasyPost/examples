package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func cancel() {
	client := easypost.New("EASYPOST_API_KEY")

	claim, _ := client.CancelClaim("clm_...")

	fmt.Println(claim)
}
