package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    toAddress, err := client.GetAddress("adr_...")
    fromAddress, err := client.GetAddress("adr_...")
    parcel, err := client.GetParcel("prcl_...")

    shipment, err := client.CreateShipmentWithCarbonOffset(
        &easypost.Shipment{
            CarrierAccountIDs: []string{"ca_..."},
            Service:           "NextDayAir",
            Parcel:            parcel,
            ToAddress:         toAddress,
            FromAddress:       fromAddress,
            Reference:         "ShipmentRef",
        },
    )
}
