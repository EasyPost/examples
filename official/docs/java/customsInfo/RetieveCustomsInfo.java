import com.easypost.EasyPost;

public class RetieveCustomsInfo {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        CustomsInfo customsInfo = CustomsInfo.retrieve("cstinfo_...");

        System.out.println(customsInfo);
    }
}