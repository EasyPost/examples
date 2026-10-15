package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	insurance, _ := client.GetInsurance("ins_...")

	fmt.Println(insurance)
}
