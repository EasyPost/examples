import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

session = client.embeddable.create_session(
    origin_host="https://example.com",
    user_id="user_...",
)

print(session)
