package customs_info;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsInfo;

public class Retieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        CustomsInfo customsInfo = CustomsInfo.retrieve("cstinfo_...");

        System.out.println(customsInfo);
    }
}
