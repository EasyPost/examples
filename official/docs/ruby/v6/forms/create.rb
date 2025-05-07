require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

form_type = 'return_packing_slip'
form_options = {
  type: 'return_packing_slip',
  barcode: 'RMA12345678900',
  line_items: [
    {
      product: {
        title: 'Square Reader',
        barcode: '855658003251',
      },
      units: '8',
    },
  ],
}

shipment = client.shipment.generate_form('shp_...', form_type, form_options)

puts shipment
