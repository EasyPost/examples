package reports;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Report;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Report report = Report.retrieve("<REPORT_ID>");

        System.out.println(report);
    }
}
