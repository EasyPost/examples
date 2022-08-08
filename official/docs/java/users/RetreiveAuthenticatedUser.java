import com.easypost.EasyPost;

public class RetreiveAuthenticatedUser {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        User user = User.retrieveMe();

        System.out.println(user);
    }
}
