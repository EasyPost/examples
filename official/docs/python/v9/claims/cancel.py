import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

claim = client.claim.cancel("clm_...")

print(claim)
