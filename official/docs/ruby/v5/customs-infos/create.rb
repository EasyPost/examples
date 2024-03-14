require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

customs_info = client.customs_info.create(
  customs_certify: true,
  customs_signer: 'Steve Brule',
  contents_type: 'merchandise',
  contents_explanation: '',
  restriction_type: 'none',
  eel_pfc: 'NOEEI 30.37(a)',
  customs_items: [
    {
      description: 'T-shirt',
      quantity: 1,
      weight: 5,
      value: 10,
      hs_tariff_number: '123456',
      origin_country: 'US',
    },
  ],
)

puts customs_info
