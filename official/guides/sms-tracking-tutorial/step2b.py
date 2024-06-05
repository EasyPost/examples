@app.route("/easypost-webhook", methods=["POST"])
def process_webhook():
    parsed_request = request.get_json()

    if parsed_request["object"] == "Event" and parsed_request["description"] == "tracker.updated":
        event = easypost.util.receive_event(request.data)
        tracker = event.result

        message = "Hey, this is FunCompany. "

        if tracker.status == "delivered":
            message += "Your package has arrived! "
        else:
            message += "There's an update on your package: "

        for tracking_detail in reversed(tracker.tracking_details):
            if tracking_detail.status == tracker.status:
                message += "%s says: %s in %s." % (
                    tracker.carrier,
                    tracking_detail.message,
                    tracking_detail.tracking_location.city,
                )
                break

        twilio_client.messages.create(to=app.config["SMS_TO_NUMBER"], from_=app.config["SMS_FROM_NUMBER"], body=message)

        return "SMS update was sent to the customer!"
