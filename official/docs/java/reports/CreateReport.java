import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateReport {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> reportMap = new HashMap<String, Object>();
        reportMap.put("type", "payment_log");
        reportMap.put("start_date", "2016-10-01");
        reportMap.put("end_date", "2016-10-31");

        Report report = Report.create(reportMap);
        
        System.out.println(report);
    }
}
