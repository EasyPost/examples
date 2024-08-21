package main

import (
	"encoding/csv"
	"errors"
	"fmt"
	"io"
	"math"
	"os"
	"strconv"
	"time"

	"github.com/EasyPost/easypost-go/v4"
)

// Concurrently buy EasyPost Insurance via a CSV file
// Usage: EASYPOST_API_KEY=123... CSV=sample.csv go run concurrent_insurance_buy.go

func main() {
	scriptStart := time.Now()

	records := getCsvRecords()

	apiKeyParam := os.Getenv("EASYPOST_API_KEY")
	if apiKeyParam == "" {
		handleGoErr(errors.New("EASYPOST_API_KEY param not set"))
	}

	client := easypost.New(apiKeyParam)
	numOfGoroutines := int(math.Min(float64(len(records)), 20))
	semaphore := make(chan bool, numOfGoroutines)
	lineMessageList := make([][]string, 0)
	lineMessageList = append(lineMessageList, []string{"Tracking Code", "Reference", "Time Elapsed", "Success", "Message"})

	// Iterate over our set of data and create an Insurance record for each line in the CSV
	for i, line := range records {
		semaphore <- true

		go func(lineNumber int, currentLine []string) {
			goroutineStartTime := time.Now()

			tracking_code := currentLine[0]
			reference := currentLine[1]
			carrier_string := currentLine[2]
			amount := currentLine[3]
			to_address_id := currentLine[4]
			from_address_id := currentLine[5]

			fmt.Printf("Sending request for %s...\n", tracking_code)
			success, message := createInsurance(client, tracking_code, reference, carrier_string, amount, to_address_id, from_address_id)

			elapsedTime := time.Since(goroutineStartTime)
			lineMessage := []string{tracking_code, reference, elapsedTime.String(), success, message}
			lineMessageList = append(lineMessageList, lineMessage)

			<-semaphore
		}(i, line)
	}

	// Gather up goroutines
	for i := 0; i < cap(semaphore); i++ {
		semaphore <- true
	}

	file, err := os.Create("insurance_buy_results.csv")
	handleGoErr(err)
	defer file.Close()
	writer := csv.NewWriter(file)
	defer writer.Flush()
	writer.WriteAll(lineMessageList)

	elapsedTotal := time.Since(scriptStart)
	fmt.Printf("\nTotal time elapsed: %s\n", elapsedTotal)
}

// getCsvRecords builds the set of data without including the header and validates it
func getCsvRecords() [][]string {
	csvParam := os.Getenv("CSV")
	if csvParam == "" {
		handleGoErr(errors.New("CSV parameter not set"))
	}

	file, err := os.Open(csvParam)
	handleGoErr(err)
	defer file.Close()
	reader := csv.NewReader(file)

	lineNumber := 0
	records := make([][]string, 0)
	for {
		record, err := reader.Read()
		// Ensure rows have valid data
		if err != nil {
			if err == io.EOF {
				break
			}
			handleGoErr(err)
		}
		if len(record) != 6 {
			handleGoErr(err)
		}

		// Skip header
		if lineNumber == 0 {
			lineNumber++
			continue
		}

		// Ensure `Amount` column is a valid float
		_, err = strconv.ParseFloat(record[3], 64)
		handleGoErr(err)

		lineNumber++
		records = append(records, record)
	}

	return records
}

// handleGoErr prints the error to stderr and exits, should be used for Go errors and not EasyPost errors
func handleGoErr(err error) {
	if err != nil {
		fmt.Fprintln(os.Stderr, err)
		os.Exit(1)
	}
}

// createInsurance creates an Insurance based on if the Tracker has a Shipment or not
func createInsurance(client *easypost.Client, tracking_code string, reference string, carrier_string string, amount string, to_address_id string, from_address_id string) (string, string) {
	// We first get the tracker to know if there is a Shipment or not so we know which Insurance endpoint to hit
	tracker, err := client.GetTracker(tracking_code)
	var eperr *easypost.APIError
	if errors.As(err, &eperr) {
		return "false", eperr.Message
	}

	if tracker.ShipmentID != "" {
		_, err := client.InsureShipment(tracker.ShipmentID, amount)
		var eperr *easypost.APIError
		if errors.As(err, &eperr) {
			return "false", eperr.Message
		}

		return "true", ""
	} else {
		// If no shipment ID, it's a standalone insurance
		_, err := client.CreateInsurance(
			&easypost.Insurance{
				ToAddress: &easypost.Address{
					ID: to_address_id,
				},
				FromAddress: &easypost.Address{
					ID: from_address_id,
				},
				Reference:    reference,
				Carrier:      carrier_string,
				TrackingCode: tracking_code,
				Amount:       amount,
			},
		)
		var eperr *easypost.APIError
		if errors.As(err, &eperr) {
			return "false", eperr.Message
		}

		return "true", ""
	}
}
