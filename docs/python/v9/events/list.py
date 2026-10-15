import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

events = client.event.all(page_size=5)

print(events)
