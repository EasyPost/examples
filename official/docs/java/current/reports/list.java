package reports;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ReportCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> reportMap = new HashMap<String, Object>();
        reportMap.put("type", "payment_log");
        reportMap.put("page_size", "5");

        ReportCollection reports = client.report.all(reportMap);

        System.out.println(reports);
    }
}
