require 'net/http'
require 'uri'

uri = URI('https://api.easypost.com/v2/carrier_claims/usps_tracker_registrations/utr_0123456789abcdef0123456789abcdef')
request = Net::HTTP::Get.new(uri)
request.basic_auth('EASYPOST_API_KEY', '')

response = Net::HTTP.start(uri.hostname, uri.port, use_ssl: true) do |http|
  http.request(request)
end
puts response.body
