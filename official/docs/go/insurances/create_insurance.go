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

    insurance, err := client.CreateInsurance(
        &easypost.Insurance{
            ToAddress:    toAddress,
            FromAddress:  fromAddress,
            Reference:    "InsuranceRef1",
            Carrier:      "USPS",
            TrackingCode: "9400110898825022579493",
            Amount:       "100.00",
        },
    )

	fmt.Println(insurance)
}
