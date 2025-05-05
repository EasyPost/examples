package example

import (
	"errors"
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	// When the `errors` key is returned as an array of FieldError objects
	_, err := client.CreateShipment(
		&easypost.Shipment{}, // Simulate a request with missing parameters: PARAMETER.REQUIRED
	)
	var invalidRequestError *easypost.InvalidRequestError
	if errors.As(err, &invalidRequestError) {
		if errorsList, ok := invalidRequestError.Errors.([]interface{}); ok {
			if fieldError, ok := errorsList[0].(*easypost.FieldError); ok {
				fmt.Println(fieldError.Message)
			}
		}
	}

	// When the `errors` key is returned as an array of strings
	_, err = client.CreateClaim(&easypost.CreateClaimParameters{
		TrackingCode: "123", // Simulate a request with an invalid tracking code: NOT_FOUND
	})
	var notFoundError *easypost.NotFoundError
	if errors.As(err, &notFoundError) {
		if errorsList, ok := notFoundError.Errors.([]interface{}); ok {
			fmt.Println(errorsList[0])
		}
	}
}
