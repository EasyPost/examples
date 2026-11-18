package example

import (
    "fmt"

    "github.com/EasyPost/easypost-go/v5"
)

func session() {
    client := easypost.New("EASYPOST_API_KEY")

    session, _ := client.CreateEmbeddablesSession(
        &easypost.EmbeddablesSessionParameters{
            OriginHost: "https://example.com",
            UserId:     "user_...",
        },
    )

    fmt.Println(session)
}
