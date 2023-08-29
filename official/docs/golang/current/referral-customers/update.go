package example

import (
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	_, _ = client.UpdateReferralCustomerEmail("user_...", "new_email@example.com")
}
