require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

parcel = EasyPost::Parcel.retrieve('prcl_...')

puts parcel
