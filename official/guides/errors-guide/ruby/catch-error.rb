require 'easypost'

begin
  Address.create({}, strict_verify: true)
rescue EasyPost::Errors::ApiError => e
  p e.code
end
