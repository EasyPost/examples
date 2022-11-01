package insurances;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Insurance;
import com.easypost.model.InsuranceCollection;

import java.util.HashMap;

public class List {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        InsuranceCollection insurances = Insurance.all(listParams);

        System.out.println(insurances);
    }
}
