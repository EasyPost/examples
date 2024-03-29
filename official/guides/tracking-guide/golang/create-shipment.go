package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    shipment, err := client.CreateShipment(
        &easypost.Shipment{
            ToAddress: &easypost.Address{
                Name:    "George Costanza",
                Company: "Vandelay Industries",
                Street1: "1 E 161st St",
                City:    "Bronx",
                State:   "NY",
                Zip:     "10451",
            },
            FromAddress: &easypost.Address{
                Company: "EasyPost",
                Street1: "417 Montgomery Street",
                Street2: "5th Floor",
                City:    "San Francisco",
                State:   "CA",
                Phone:   "415-528-7555",
                Zip:     "94104",
            },
            Parcel: &easypost.Parcel{
                Length: 9,
                Width:  6,
                Height: 2,
                Weight: 10,
            },
        },
    )

    shipment, err := client.BuyShipment(shipment.ID, shipment.Rates[0], "100.00")
}
