import easypost

easypost.api_key = "EASYPOST_API_KEY"

endshippers = easypost.EndShipper.all(page_size=5)

print(endshippers)
