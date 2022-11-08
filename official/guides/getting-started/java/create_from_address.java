import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey = "<YOUR_TEST/PRODUCTION_API_KEY>";

Map<String, Object> fromAddressMap = new HashMap<String, Object>();
addressMap.put("company", "EasyPost");
addressMap.put("street1", "417 Montgomery Street");
addressMap.put("street2", "5th Floor");
addressMap.put("city", "San Francisco");
addressMap.put("state", "CA");
addressMap.put("zip", "94104");
addressMap.put("phone", "415-528-7555");

Address fromAddress = Address.create(fromAddressMap);
