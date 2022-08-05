import com.easypost.EasyPost;

public class RetrieveInsurance {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Insurance insurance = Insurance.retrieve("ins_...");

        System.out.println(insurance);
    }
}
