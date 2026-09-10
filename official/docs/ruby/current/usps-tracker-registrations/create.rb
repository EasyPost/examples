require 'net/http'
require 'json'
require 'uri'

uri = URI('https://api.easypost.com/v2/carrier_claims/usps_tracker_registrations')
request = Net::HTTP::Post.new(uri)
request.basic_auth('EASYPOST_API_KEY', '')
request['Content-Type'] = 'application/json'
request.body = {
  tracker_registrations: [
    {
      tracking_code: '9400111899223344556677',
      product_value: '25.50',
    },
  ],
}.to_json

response = Net::HTTP.start(uri.hostname, uri.port, use_ssl: true) do |http|
  http.request(request)
end
puts response.body
