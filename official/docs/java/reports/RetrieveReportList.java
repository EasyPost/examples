import com.easypost.EasyPost;
import java.util.HashMap;

public class RetrieveReport {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> reportMap = new HashMap<String, Object>();
        reportMap.put("type", "payment_log");
        reportMap.put("page_size", "5");

        ReportCollection reports = Report.all(reportMap);

        System.out.println(reports);
    }
}
