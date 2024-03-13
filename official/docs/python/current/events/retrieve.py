import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

event = client.event.retrieve("evt_...")

print(event)
