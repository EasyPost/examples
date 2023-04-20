package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	// Request all metadata for all carriers
	carrierMetadata, _ := client.BetaGetCarrierMetadata()
	fmt.Println(carrierMetadata)

	// Request specific metadata for specific carriers
	carrierMetadataWithFilters, _ := client.BetaGetCarrierMetadataWithCarriersAndTypes([]string{"usps"}, []string{"service_levels", "predefined_packages"})
	fmt.Println(carrierMetadataWithFilters)
}
