package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	claim, _ := client.CreateClaim(
		&easypost.CreateClaimParameters{
			Amount:                             "100",
			TrackingCode:                       "EZ1000000001",
			EmailEvidenceAttachments:           []string{"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=="},
			InvoiceAttachments:                 []string{"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=="},
			SupportingDocumentationAttachments: []string{"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=="},
			Description:                        "Test Description",
			ContactEmail:                       "test@example.com",
		},
	)

	fmt.Println(claim)
}
