import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveReport {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> reportMap = new HashMap<String, Object>();
        reportMap.put("type", "payment_log");
        reportMap.put("page_size", "4");
        reportMap.put("start_date", "2016-01-02");

        ReportCollection reports = Report.all(reportMap);
        
        System.out.println(reports);
    }
}