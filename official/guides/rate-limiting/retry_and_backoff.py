import requests
from urllib3.util.retry import Retry


retry_strategy = Retry(
    total=3,
    backoff_factor=1,
    status_forcelist=[
        429,
        500,
        502,
        503,
        504,
    ],
    allowed_methods=[
        "DELETE",
        "GET",
    ],
)
requests_session = requests.Session()
requests_http_adapter = requests.adapters.HTTPAdapter(max_retries=retry_strategy)
requests_session.mount(prefix="https://", adapter=requests_http_adapter)
