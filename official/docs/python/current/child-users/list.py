import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

childUsers = client.user.all_children(page_size=5)

print(childUsers)
