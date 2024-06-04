class App < Sinatra::Base
  set :show_exceptions, :after_handler
  configure :development, :test do
    Dotenv.load
  end
  configure do
    EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')
    set :sendgrid, SendGrid::API.new(api_key: 'SENDGRID_API_KEY')
  end

  post '/easypost-webhook' do
    request_string = request.body.read
    parsed_request = JSON.parse(request_string)

    if parsed_request['object'] == 'Event' && parsed_request['description'] == 'tracker.updated'
      event = EasyPost::Util.receive_event(request_string)
      tracker = event.result

      message = 'Hey, this is FunCompany.'
      message += if tracker.status == 'delivered'
                   'Your package has arrived! '
                 else
                   "There's an update on your package: "
                 end

      td = tracker.tracking_details.reverse.find { |tracking_detail| tracking_detail.status == tracker.status }
      message += "#{tracker.carrier} says: #{td.message} in #{td.tracking_location.city}." if td.present?

      from = SendGrid::Email.new(email: 'test@fromaddress.com')
      subject = 'Hello World from the SendGrid Ruby Library!'
      to = SendGrid::Email.new(email: 'customer@gmail.com')
      content = SendGrid::Content.new(type: 'text/plain', value: message)
      mail = SendGrid::Mail.new(from, subject, to, content)

      settings.sendgrid.client.mail._('send').post(request_body: mail.to_json)

      [200, {}, 'Email update was sent to the customer!']
    else
      [200, {}, 'Not a Tracker event, so nothing to do here for now...']
    end
  end

  run! if app_file == $PROGRAM_NAME
end
