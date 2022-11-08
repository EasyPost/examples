import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey = "<YOUR_PRODUCTION_API_KEY>";

Map<String, Object> params = new HashMap<String, Object>();
params.put("recharge_threshold", "50.00");

User me = User.retrieveMe();
me.update(params);
