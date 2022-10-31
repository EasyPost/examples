package current.carbon-offset;

public class one-call-buy
{

}

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey="<YOUR_TEST/PRODUCTION_API_KEY>";

Map<String, Object> toAddressMap = new HashMap<String, Object>();...

Map<String, Object> fromAddressMap = new HashMap<String, Object>();...

Map<String, Object> parcelMap = new HashMap<String, Object>();...

Map<String, Object> shipmentMap = new HashMap<String, Object>();shipmentMap.put("carrier_accounts","ca_...");shipmentMap.put("service","NextDayAir");shipmentMap.put("to_address",toAddressMap);shipmentMap.put("from_address",fromAddressMap);shipmentMap.put("parcel",parcelMap);

Shipment shipment = Shipment.create(shipmentMap, true);
