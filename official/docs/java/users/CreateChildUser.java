import com.easypost.EasyPost;

public class CreateChildUser {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> userMap = new HashMap<String, Object>();
        userMap.put("name", "Child Account Name");

        User user = User.create(userMap);

        System.out.println(user);
    }
}
