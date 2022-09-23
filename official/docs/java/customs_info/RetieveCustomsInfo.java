package customs_info;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsInfo;

public class RetieveCustomsInfo {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        CustomsInfo customsInfo = CustomsInfo.retrieve("cstinfo_...");

        System.out.println(customsInfo);
    }
}
