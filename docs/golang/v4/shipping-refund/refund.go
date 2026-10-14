package shipping_refund

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func refund() {
	client := easypost.New("EASYPOST_API_KEY")

	shipment, _ := client.RefundShipment("shp_...")

	fmt.Println(shipment)
}
