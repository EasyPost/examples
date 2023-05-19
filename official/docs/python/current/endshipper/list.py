import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

end_shippers = client.end_shipper.all(page_size=5)

print(end_shippers)
