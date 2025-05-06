package errors;

import java.util.HashMap;
import java.util.Map;

import com.easypost.exception.APIException;
import com.easypost.exception.General.EasyPostException;
import com.easypost.model.Claim;
import com.easypost.service.EasyPostClient;

public class CatchError {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        // When the `errors` key is returned as an array of FieldError objects
        try {
            Map<String, Object> shipmentData = new HashMap<>();
            // Simulate a request with missing parameters: PARAMETER.REQUIRED
            client.shipment.create(shipmentData);
        } catch (APIException exception) {
            FieldError fieldError = (FieldError) exception.getErrors().get(0);
            System.err.println(fieldError.getMessage());
        }

        // When the `errors` key is returned as an array of strings
        try {
            Map<String, Object> claimData = new HashMap<>();
            claimData.put("tracking_code", "123"); // Simulate a request with an invalid tracking code: NOT_FOUND
            Claim claim = client.claim.create(claimData);
        } catch (APIException exception) {
            System.err.println(exception.getErrors().get(0));
        }
    }
}
