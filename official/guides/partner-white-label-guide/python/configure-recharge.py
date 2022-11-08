import easypost
easypost.api_key = "<YOUR_PRODUCTION_API_KEY>"

me = easypost.User.retrieve()
me.recharge_threshold = "50.00"
me.save()
