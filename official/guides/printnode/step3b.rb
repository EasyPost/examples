require 'sinatra/base'
require 'easypost'
require 'printnode'
require 'tilt/erb'
require 'dotenv'

class App < Sinatra::Base
  configure do
    Dotenv.load
    EasyPost.api_key = 'EASYPOST_API_KEY'
    set :printnode_client, PrintNode::Client.new(PrintNode::Auth.new('PRINTNODE_API_KEY'))
    set :printer_id, 'PRINTNODE_PRINTER_ID'
  end

  get '/' do
    "Hello World! Our printer id is #{settings.printer_id}"
  end

  # start the server if this file is executed directly
  run! if app_file == $PROGRAM_NAME
end
