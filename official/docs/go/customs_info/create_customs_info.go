package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
    client := easypost.New(apiKey)

	customsInfo, err := client.CreateCustomsInfo(
        &easypost.CustomsInfo{
            CustomsCertify: true,
			CustomsSigner: "Steve Brule",
			ContentsType: "merchandise",
			ContentsExplanation: "",
			RestrictionType: "none",
            EELPFC:         "NOEEI 30.37(a)",
            CustomsItems: []*easypost.CustomsItem{
                &easypost.CustomsItem{
                    Description:   "T-shirt,
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
