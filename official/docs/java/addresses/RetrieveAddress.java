import com.easypost.EasyPost;

public class RetrieveAddress {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Address address = Address.retrieve("adr_...");

        System.out.println(address);
    }
}
