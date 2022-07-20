require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

form = EasyPost::Shipment.create(
    {
        type: 'return_packing_slip',
        barcode: 'RMA12345678900',
        line_items: [
            {
                product: {
                    title: 'Square Reader',
                    barcode: '855658003251',
                }
                units: '8',
            }
        ]
    }
)

puts form
