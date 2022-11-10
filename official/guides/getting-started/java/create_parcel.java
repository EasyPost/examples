package getting_started;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateParcel {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("height", 9);
        parcelMap.put("width", 6);
        parcelMap.put("length", 2);
        parcelMap.put("weight", 10);

        Parcel parcel = Parcel.create(parcelMap);
    }
}
