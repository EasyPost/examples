require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

child_users = client.user.all_children(
  page_size: 5,
)

puts child_users
