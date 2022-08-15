package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, _ := client.BuyShipment("shp_...", nil, "100")

	formType := "return_packing_slip"
	formOptions := map[string]interface{}{
		"barcode": "RMA12345678900",
		"line_items": []map[string]interface{}{
			{
				"product": map[string]interface{}{
					"title":   "Square Reader",
					"barcode": "855658003251",
				},
				"units": 8,
			},
		},
	}

	shipmentWithForm, _ := client.GenerateShipmentFormWithOptions(shipment.ID, formType, formOptions)

	fmt.Println(shipmentWithForm)
}
