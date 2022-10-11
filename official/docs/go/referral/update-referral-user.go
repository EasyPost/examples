package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
	client := easypost.New(apiKey)

	_, _ = client.UpdateReferralCustomerEmail("user_...", "new_email@example.com")
}
