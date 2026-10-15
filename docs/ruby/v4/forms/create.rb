require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

shipment = EasyPost::Shipment.retrieve('shp_...')

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

shipment.generate_form(form_type, form_options)

puts shipment
