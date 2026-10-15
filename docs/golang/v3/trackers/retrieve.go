package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	tracker, _ := client.GetTracker("trk_...")

	fmt.Println(tracker)
}
