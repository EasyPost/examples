require 'easypost'

begin
  Address.create({}, strict_verify: true)
rescue EasyPost::Error => e
  p e.code
end
