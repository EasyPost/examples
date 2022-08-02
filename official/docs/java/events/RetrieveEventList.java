import com.easypost.EasyPost;

public class RetrieveEventList {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> params = new HashMap<>();

        params.put("page_size", 5);

        EventCollection events = Event.all(params);

        System.out.println(events);
    }
}
