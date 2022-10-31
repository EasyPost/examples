import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey="<YOUR_TEST/PRODUCTION_API_KEY>";

List<Shipment>shipments=new ArrayList<Shipment>();shipments.add(shipment);

Map<String,Object>paramMap=new HashMap<String,Object>();paramMap.put("shipments",shipments);

ScanForm scanForm=ScanForm.create(paramMap);package current.scan-form;

public class create {

}
