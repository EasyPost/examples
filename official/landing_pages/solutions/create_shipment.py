# Import the EasyPost client.
import easypost


# Setup the client with your API key.
easypost.api_key = "259DA788-39A3-439E-BA1E-BC541B8BA520"

# Purchase a shipment to receive a postage label.
shipment = easypost.Shipment.retrieve("shp_339f74ca0aa840d399bbb728a3ac3863")
shipment.buy(rate=shipment.lowest_rate())
