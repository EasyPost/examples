import easypost

easypost.api_key = "EASYPOST_API_KEY"

event = easypost.Event.retrieve("evt_...")

print(event)
