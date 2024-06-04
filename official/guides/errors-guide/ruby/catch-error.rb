require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

begin
  client.address.create({strict_verify: true})
rescue EasyPost::Errors::Api::ApiError => e
  puts e.code
end
