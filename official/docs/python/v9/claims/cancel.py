import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

claim = client.claim.refund("clm_...")

print(claim)
