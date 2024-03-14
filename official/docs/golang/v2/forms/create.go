package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	shipmentWithForm, _ := client.GenerateShipmentForm("shp_...", "return_packing_slip")

	fmt.Println(shipmentWithForm)
}
