package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	// Request all metadata for all carriers
	carrierMetadata, _ := client.GetCarrierMetadata()
	fmt.Println(carrierMetadata)

	// Request specific metadata for specific carriers
	carrierMetadataWithFilters, _ := client.GetCarrierMetadataWithCarriersAndTypes([]string{"usps"}, []string{"service_levels", "predefined_packages"})
	fmt.Println(carrierMetadataWithFilters)
}
