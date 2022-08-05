import com.easypost.EasyPost;

public class UpdateBrand {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        User user = User.retrieveMe();

        Map<String, Object> params = new HashMap<>();
        params.put("color", "303F9F");

        Brand brand = user.updateBrand(params);

        System.out.println(brand);
    }
}
