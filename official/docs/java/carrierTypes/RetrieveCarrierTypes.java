import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveCarrierTypes {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        List<CarrierType> carrierTypes = CarrierType.all();

        System.out.println(carrierTypes);
    }
}
