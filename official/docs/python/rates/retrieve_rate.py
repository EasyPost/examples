import easypost


easypost.api_key = "EASYPOST_API_KEY"

rate = easypost.Rate.retrieve("rate...")

print(rate)
