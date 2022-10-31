package parcels;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Parcel;

public class RetrieveParcel {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Parcel parcel = Parcel.retrieve("prcl_...");

        System.out.println(parcel);
    }
}
