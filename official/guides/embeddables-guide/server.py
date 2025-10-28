import os
import requests
from flask import Flask, jsonify
app = Flask(__name__)
EASYPOST_API_KEY = os.environ.get("EASYPOST_API_KEY", "")


@app.route("/api/easypost-embeddables/session", methods=["GET"])
def create_embeddable_session():
    payload = {
        "user_id": "SUB_ACCOUNT_USER_ID",  # Replace with sub-account user ID
        "origin_host": "ORIGIN_HOST",  # Replace with integrator's domain
    }

    response = requests.post(
        "https://api.easypost.com/v2/embeddables/session",
        auth=(EASYPOST_API_KEY, ""),
        json=payload,
        headers={"Content-Type": "application/json"},
        timeout=10,
    )
    response.raise_for_status()
    return jsonify(response.json())


if __name__ == "__main__":
    app.run(port=5000, debug=True)
