package example

import (
	"errors"
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	var apiError *easypost.APIError

	// When the `errors` key is returned as an array of FieldError objects
	_, err := client.CreateShipment(
		&easypost.Shipment{}, // Simulate a request with missing parameters
	)
	if errors.As(err, &apiError) {
		if errorsList, ok := apiError.Errors.([]interface{}); ok {
			if fieldError, ok := errorsList[0].(*easypost.FieldError); ok {
				fmt.Println(fieldError.Message)
			}
		}
	}

	// When the `errors` key is returned as an array of strings
	_, err = client.CreateClaim(&easypost.CreateClaimParameters{
		TrackingCode: "123", // Simulate a request with an invalid tracking code
	})
	if errors.As(err, &apiError) {
		if errorsList, ok := apiError.Errors.([]interface{}); ok {
			fmt.Println(errorsList[0])
		}
	}
}
