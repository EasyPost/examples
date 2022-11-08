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
    EasyPost.api_key = ENV['EASYPOST_API_KEY']
    set :sendgrid, SendGrid::API.new(api_key: ENV['SENDGRID_API_KEY'])
  end
end
