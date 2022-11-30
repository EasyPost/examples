package reports;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Report;
import com.easypost.model.ReportCollection;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> reportMap = new HashMap<String, Object>();
        reportMap.put("type", "payment_log");
        reportMap.put("page_size", "5");

        ReportCollection reports = Report.all(reportMap);

        System.out.println(reports);
    }
}
