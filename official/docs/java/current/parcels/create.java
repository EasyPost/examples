package parcels;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Parcel;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("height", 5);
        params.put("width", 10.9);
        params.put("length", 20.2);
        params.put("weight", 65.9);

        Parcel parcel = client.parcel.create(params);

        System.out.println(parcel);
    }
}
