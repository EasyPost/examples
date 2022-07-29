import easypost
easypost.api_key = "EASYPOST_API_KEY"

events = easypost.Events.all(
    page_size = 5
)
