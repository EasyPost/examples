require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_user = client.user.retrieve('user_...')

client.user.delete(retrieved_user.id)
