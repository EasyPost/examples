package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	toAddress, err := client.GetAddress("adr_...")
    fromAddress, err := client.GetAddress("adr_...")
    parcel, err := client.GetParcel("prcl_...")

    shipment, err := client.CreateShipment(
        &easypost.Shipment{
            ToAddress:   toAddress,
            FromAddress: fromAddress,
            Parcel:      parcel,
            TaxIdentifiers: []*easypost.TaxIdentifier{
                &easypost.TaxIdentifier{
                    Entity:         "SENDER",
                    TaxId:          "GB123456789",
                    IssuingCountry: "GB",
                    TaxIdType:      "EORI",
                },
            },
        },
    )

	fmt.Println(shipment)
}
