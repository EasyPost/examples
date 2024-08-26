package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")

	insurance, _ := client.CreateInsurance(
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
