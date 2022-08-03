import com.easypost.EasyPost;

public class DeleteChildUser {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        User user = User.retrieve("user_...");

        user.delete();

        System.out.println(user);
    }
}
