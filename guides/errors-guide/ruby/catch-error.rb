require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

# When the `errors` key is returned as an array of FieldError objects
begin
  # Simulate a request with missing parameters
  client.shipment.create({})
rescue EasyPost::Errors::Api::ApiError => e
  puts e.errors[0]['message']
end

# When the `errors` key is returned as an array of strings
begin
  client.claim.create(
    tracking_code: '123', # Simulate a request with an invalid tracking code
  )
rescue EasyPost::Errors::Api::ApiError => e
  puts e.errors[0]
end
