require 'sinatra/base'
require 'easypost'
require 'tilt/erb'
require 'dotenv'

class App < Sinatra::Base
  configure :development, :test do
    Dotenv.load
  end
  configure do
    EasyPost.api_key = ENV['EASYPOST_API_KEY']
  end

  get '/' do
    'Hello World'
  end

  # start the server if this file is executed directly
  run! if app_file == $PROGRAM_NAME
end
