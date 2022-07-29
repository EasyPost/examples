import org.apache.commons.codec.net.QCodec;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

public class CreateForm {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Shipment shipment = Shipment.retrieve("rate_...");

        Map<String, Object> titleMap = new HashMap<String, Object>();
        titleMap.put("title", "Square Reader");

        Map<String, Object> barcodeMap = new HashMap<String, Object>();
        barcodeMap.put("barcode", "855658003251");

        ArrayList<Map<String, Object>> lineItemsMap = new ArrayList<Map<String, Object>>();
        lineItemsMap.add(titleMap);
        lineItemsMap.add(barcodeMap);

        Map<String, Object> formMap = new HashMap<String, Object>();
        formMap.put("barcode", "RMA12345678900");
        formMap.put("units", 8);
        formMap.put("line_items", lineItemsMap);

        shipment.generateForm("return_packing_slip", formMap);

        System.out.println(shipment);
    }
}
