package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	retrievedEndShipper, _ := client.GetEndShipper("es_...")

	fmt.Println(retrievedEndShipper)
}
