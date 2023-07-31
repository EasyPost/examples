import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

user = client.user.retrieve("user_...")

client.user.delete(user.id)
