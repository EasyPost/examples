import com.easypost.EasyPost;

public class RetrieveInsuranceList {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        InsuranceCollection insurances = Insurance.all(list_params);

        System.out.println(insurances);
    }
}
