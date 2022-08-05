import com.easypost.EasyPost;

public class RetrieveCarrierTypes {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        List<CarrierType> carrierTypes = CarrierType.all();

        System.out.println(carrierTypes);
    }
}
