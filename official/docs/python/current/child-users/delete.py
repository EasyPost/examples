import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.user.delete("user_...")
