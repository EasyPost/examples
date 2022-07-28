import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class DeleteUser {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";
        
        User user = User.retrieve("user_...");
        
        user.delete();   

        System.out.println(user);
    }
}
