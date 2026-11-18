package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func create() {
	client := easypost.New("EASYPOST_API_KEY")

	claim, _ := client.CreateClaim(
		&easypost.CreateClaimParameters{
			Amount:                             100.00,
			TrackingCode:                       "EZ1000000001",
			EmailEvidenceAttachments:           []string{"REPLACE_WITH_BASE64_STRING"},
			InvoiceAttachments:                 []string{"REPLACE_WITH_BASE64_STRING"},
			SupportingDocumentationAttachments: []string{"REPLACE_WITH_BASE64_STRING"},
			Description:                        "Test Description",
			ContactEmail:                       "test@example.com",
		},
	)

	fmt.Println(claim)
}
