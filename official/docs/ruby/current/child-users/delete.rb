require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

retrieved_user = client.user.retrieve('user_...')

success = client.user.delete(retrieved_user.id)

puts success
