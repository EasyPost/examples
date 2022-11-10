shipment, err := client.GetShipment("shp_...")
rate := shipment.Rates[0]
    
shipment, err = client.BuyShipment(shipment.ID, rate, "100.00")
