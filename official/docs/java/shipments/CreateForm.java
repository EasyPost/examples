package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

import java.util.ArrayList;
import java.util.HashMap;

public class CreateForm {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Shipment shipment = Shipment.retrieve("shp_...");
        shipment.buy(shipment.lowestRate());

        HashMap<String, Object> titleMap = new HashMap<String, Object>();
        titleMap.put("title", "Square Reader");

        HashMap<String, Object> barcodeMap = new HashMap<String, Object>();
        barcodeMap.put("barcode", "855658003251");

        ArrayList<HashMap<String, Object>> lineItemsMap = new ArrayList<HashMap<String, Object>>();
        lineItemsMap.add(titleMap);
        lineItemsMap.add(barcodeMap);

        HashMap<String, Object> formMap = new HashMap<String, Object>();
        formMap.put("barcode", "RMA12345678900");
        formMap.put("units", 8);
        formMap.put("line_items", lineItemsMap);

        shipment.generateForm("return_packing_slip", formMap);

        System.out.println(shipment);
    }
}
