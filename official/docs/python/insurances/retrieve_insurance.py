import easypost


easypost.api_key = "EASYPOST_API_KEY"

insurance = easypost.Insurance.retrieve("ins_...")

print(insurance)
