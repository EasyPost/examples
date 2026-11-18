package example

import (
    "fmt"

    "github.com/EasyPost/easypost-go/v6"
)

func session() {
    client := easypost.New("EASYPOST_API_KEY")

    session, _ := client.CreateEmbeddablesSession(
        &easypost.EmbeddablesSessionParameters{
            OriginHost: "https://example.com",
            UserID:     "user_...",
        },
    )

    fmt.Println(session)
}
