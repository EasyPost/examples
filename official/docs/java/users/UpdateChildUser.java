import com.easypost.EasyPost;

public class UpdateChildUser {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> params = new HashMap<String, Object>();
        params.put("name", "Test Child");

        User user = User.retrieveMe();

        user.update(params);

        System.out.println(user);
    }
}
