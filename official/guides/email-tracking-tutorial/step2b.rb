require 'sinatra/base'
require 'easypost'
require 'sendgrid-ruby'
require 'tilt/erb'
require 'pry'
require 'dotenv'

class App < Sinatra::Base
  set :show_exceptions, :after_handler
  configure :development, :test do
    Dotenv.load
  end
  configure do
    client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')
    set :sendgrid, SendGrid::API.new(api_key: 'SENDGRID_API_KEY')
  end
end
