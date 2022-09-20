import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

endshipper = easypost.EndShipper.create(
    name="FOO BAR",
    company="BAZ",
    street1="164 TOWNSEND STREET UNIT 1",
    street2="UNIT 1",
    city="SAN FRANCISCO",
    state="CA",
    zip="94107",
    country="US",
    phone="555 555-5555",
    email="FOO@EXAMPLE.COM",
)

endshipper.name = "NEW NAME"
endshipper.company = "BAZ"
endshipper.street1 = "164 TOWNSEND STREET UNIT 1"
endshipper.street2 = "UNIT 1"
endshipper.city = "SAN FRANCISCO"
endshipper.state = "CA"
endshipper.zip = "94107"
endshipper.country = "US"
endshipper.phone = "555-555-5555"
endshipper.email = "FOO@EXAMPLE.COM"

endshipper = endshipper.save()

print(endshipper)
