import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

claim = client.claim.retrieve("clm_...")

print(claim)
