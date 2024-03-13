package customs_info;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsInfo;
import com.easypost.service.EasyPostClient;

public class Retieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        CustomsInfo customsInfo = client.customsInfo.retrieve("cstinfo_...");

        System.out.println(customsInfo);
    }
}
