package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
	client := easypost.New(apiKey)

	shipment, err = client.BuyShipment("shp_...", nil, nil)

	formType := "return_packing_slip"
	formOption := map[string]interface{}{
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

	shipmentWithForm, err := client.GenerateShipmentForm(shipment.ID, formType, formOption)
}
