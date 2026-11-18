package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func delete() {
	client := easypost.New("EASYPOST_API_KEY")

	err := client.DeleteUser("user_...")

	fmt.Println(err)
}
