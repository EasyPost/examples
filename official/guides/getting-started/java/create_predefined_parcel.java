package getting_started;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreatePredefinedParcel {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("predefined_package", "FlatRateEnvelope");
        parcelMap.put("weight", 10);

        Parcel.create(parcelMap);
    }
}
