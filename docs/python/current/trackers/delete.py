import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.tracker.delete("trk_...")
