package example

import (
    "os"

    "github.com/EasyPost/easypost-go/v2"
)

func main() {
    apiKey := os.Getenv("<YOUR_PRODUCTION_API_KEY>")
    client := easypost.New(apiKey)

    user, err := client.RetrieveMe()
    rechargeThreshold := "50.00"

    user, err := client.UpdateUser(
        &easypost.UserOptions{
            RechargeAmount: &rechargeThreshold,
        },
    )
}
