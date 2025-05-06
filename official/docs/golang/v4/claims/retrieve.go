package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	claim, _ := client.GetClaim("clm_...")

	fmt.Println(claim)
}
