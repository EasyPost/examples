package parcels;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Parcel;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("height", 5);
        parcelMap.put("width", 10.9);
        parcelMap.put("length", 20.2);
        parcelMap.put("weight", 65.9);

        Parcel parcel = Parcel.create(parcelMap);

        System.out.println(parcel);
    }
}
