require 'easypost'

begin
  Address.create({}, strict_verify: true)
rescue EasyPost::Errors::ApiError => error
  p error.code
end
