package example

import (
	"github.com/EasyPost/easypost-go/v4"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	_, _ = client.UpdateReferralCustomerEmail("user_...", "new_email@example.com")
}
