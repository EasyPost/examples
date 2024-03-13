package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	customsInfo, _ := client.CreateCustomsInfo(
		&easypost.CustomsInfo{
			CustomsCertify:      true,
			CustomsSigner:       "Steve Brule",
			ContentsType:        "merchandise",
			ContentsExplanation: "",
			RestrictionType:     "none",
			EELPFC:              "NOEEI 30.37(a)",
			CustomsItems: []*easypost.CustomsItem{
				&easypost.CustomsItem{
					Description:   "T-shirt",
					Quantity:      1,
					Value:         10.00,
					Weight:        5,
					OriginCountry: "US",
				},
			},
		},
	)

	fmt.Println(customsInfo)
}
