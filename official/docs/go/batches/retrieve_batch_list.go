package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	batches, err := client.ListBatches(
		&easypost.ListOptions{
			PageSize: 5,
		},
	)

	fmt.Println(batches) 
}
