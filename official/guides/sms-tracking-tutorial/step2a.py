import easypost
from flask import Flask
from twilio.rest import TwilioRestClient

app = Flask(__name__)
app.config.from_object("config")

client = easypost.EasyPostClient(app.config["EASYPOST_API_KEY"])
twilio_client = TwilioRestClient(app.config["TWILIO_ACCOUNT_SID"], app.config["TWILIO_AUTH_TOKEN"])
