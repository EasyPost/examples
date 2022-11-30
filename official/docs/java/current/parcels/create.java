package parcels;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Parcel;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("height", 5);
        parcelMap.put("width", 10.9);
        parcelMap.put("length", 20.2);
        parcelMap.put("weight", 65.9);

        Parcel parcel = client.parcel.create(parcelMap);

        System.out.println(parcel);
    }
}
