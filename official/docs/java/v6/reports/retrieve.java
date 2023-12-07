package reports;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Report;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Report report = client.report.retrieve("<REPORT_ID>");

        System.out.println(report);
    }
}
