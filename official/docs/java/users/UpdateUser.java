import com.easypost.EasyPost;

public class UpdateUser {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> params = new HashMap<String, Object>();
        params.put("recharge_threshold", "50.00");

        User user = User.retrieveMe();

        user.update(params);

        System.out.println(user);
    }
}
