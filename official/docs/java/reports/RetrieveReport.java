package reports;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Report;

public class RetrieveReport {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Report report = Report.retrieve("<REPORT_ID>");

        System.out.println(report);
    }
}
