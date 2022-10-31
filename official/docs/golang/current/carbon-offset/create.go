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
    customsInfo, err := client.GetCustomsInfo("cstinfo_...")

    shipment, err := client.CreateShipmentWithCarbonOffset(
        &easypost.Shipment{
            ToAddress:   toAddress,
            FromAddress: fromAddress,
            Parcel:      parcel,
            CustomsInfo: customsInfo,
	})
}
