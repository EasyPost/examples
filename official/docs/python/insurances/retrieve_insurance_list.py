import easypost


easypost.api_key = "EASYPOST_API_KEY"

insurances = easypost.Insurance.all(page_size=5)

print(insurances)
