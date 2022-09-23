import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

endshippers = easypost.EndShipper.all(page_size=5)

print(endshippers)
