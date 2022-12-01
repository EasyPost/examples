package reports;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Report;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("type", "payment_log");
        params.put("start_date", "2022-10-01");
        params.put("end_date", "2022-10-31");

        Report report = client.report.create(params);

        System.out.println(report);
    }
}
