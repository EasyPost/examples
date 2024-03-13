package parcels;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Parcel;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Parcel parcel = client.parcel.retrieve("prcl_...");

        System.out.println(parcel);
    }
}
