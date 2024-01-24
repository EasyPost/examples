require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

childUsers = client.user.all_children(
  page_size: 5,
)

puts childUsers
