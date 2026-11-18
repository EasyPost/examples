package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func cancel() {
	client := easypost.New("EASYPOST_API_KEY")

	pickup, _ := client.CancelPickup("pickup_...")

	fmt.Println(pickup)
}
