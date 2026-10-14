import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

claims = client.claim.all(page_size=5)

print(claims)
