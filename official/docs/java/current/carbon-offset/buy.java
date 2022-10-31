import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey="<YOUR_TEST/PRODUCTION_API_KEY>";

Shipment shipment=Shipment.retrieve("shp_...");Map<String,Object>buyMap=new HashMap<String,Object>();buyMap.put("rate",shipment.lowestRate());buyMap.put("insurance",249.99);

shipment.buy(buyMap,true);
package current.carbon

-offset;

public class buy {

}
