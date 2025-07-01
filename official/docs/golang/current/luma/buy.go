package luma

import (
	"fmt"
	"github.com/EasyPost/easypost-go/v5"
)

func Buy() {
	client := easypost.New("EASYPOST_API_KEY")
	params := map[string]interface{}{
		"shipment_id": "shp_...",
		"rate_id":     "rate_...",
	}
	response, err := client.Do("POST", "/v2/luma/buy", params)
	if err != nil {
		panic(err)
	}

	fmt.Println(response)
}
