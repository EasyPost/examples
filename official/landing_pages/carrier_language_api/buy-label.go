package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

    parcel, err := client.CreateParcel(
        &easypost.Parcel(
          PredefinedPackage: "Parcel",
          Weight: 28,
        ),
      )

      shipment, err := client.CreateShipment(
        &easypost.Shipment(
          ToAddress: toAddress,
          FromAddress: fromAddress,
          Parcel: parcel,
        ),
      )

      shipment, err = client.BuyShipment(shipment.ID, shipment.Rates[0])
}
