require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

session = client.embeddable.create_session(
  {
    origin_host: 'https://example.com',
    user_id: 'user_...',
  },
)

puts session
