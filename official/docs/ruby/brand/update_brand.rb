require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

user = EasyPost::User.retrieve_me

color = '#303F9F'

brand = user.update_brand(
  color: '#303F9F',
  logo: 'data:image/png;base64,iVBORw0K...',
  logo_href: 'https://www.easypost.com',
  ad: 'null',
  ad_href: 'null',
  theme: 'theme1',
)

puts brand
