import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey="<YOUR_TEST/PRODUCTION_API_KEY>";

Map<String,Object>toAddressMap=new HashMap<String,Object>();...

Map<String,Object>fromAddressMap=new HashMap<String,Object>();...

Map<String,Object>parcelMap=new HashMap<String,Object>();...

Map<String,Object>customsInfoMap=new HashMap<String,Object>();...

Map<String,Object>shipmentMap=new HashMap<String,Object>();shipmentMap.put("to_address",toAddressMap);shipmentMap.put("from_address",fromAddressMap);shipmentMap.put("parcel",parcelMap);shipmentMap.put("customs_info",customsInfoMap);

Shipment shipment=Shipment.create(shipmentMap,true);package current.carbon-offset;

public class create {

}
