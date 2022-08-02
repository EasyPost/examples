import com.easypost.EasyPost;

public class RetreiveAuthenticatedUser {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        User user = User.retrieveMe();

        System.out.println(user);
    }
}
