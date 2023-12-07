import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

end_shipper = client.end_shipper.retrieve("es_...")

updated_end_shipper = client.end_shipper.update(
    end_shipper.id,
    name="NEW NAME",
    company="BAZ",
    street1="164 TOWNSEND STREET UNIT 1",
    street2="UNIT 1",
    city="SAN FRANCISCO",
    state="CA",
    zip="94107",
    country="US",
    phone="555-555-5555",
    email="FOO@EXAMPLE.COM",
)

print(updated_end_shipper)
