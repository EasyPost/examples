import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey = "<YOUR_PRODUCTION_API_KEY>";

boolean success = Billing.fundWallet("2000", PaymentMethod.Priority.PRIMARY);
