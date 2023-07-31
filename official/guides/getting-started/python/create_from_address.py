import easypost

easypost.api_key = "<YOUR_TEST/PRODUCTION_API_KEY>"

fromAddress = easypost.Address.create(
    company="EasyPost",
    street1="417 Montgomery Street",
    street2="5th Floor",
    city="San Francisco",
    state="CA",
    zip="94104",
    phone="415-528-7555",
)
