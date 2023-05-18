require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

retrieved_endshipper = client.end_shipper.retrieve('es_...')

update_data = {
  'name' => 'New Name',
  'street1' => '388 Townsend St',
  'street2' => 'Apt 20',
  'city' => 'San Francisco',
  'state' => 'CA',
  'zip' => '94107',
  'country' => 'US',
  'email' => 'test@example.com',
  'phone' => '5555555555',
}

endshipper = client.end_shipper.update(retrieved_endshipper.id, update_data)

puts endshipper
