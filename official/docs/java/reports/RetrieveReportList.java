import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveReportList {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Report report = Report.retrieve("<REPORT_ID>");

        System.out.println(report);
    }
}
