package insurances;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Insurance;

public class RetrieveInsurance {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Insurance insurance = Insurance.retrieve("ins_...");

        System.out.println(insurance);
    }
}
