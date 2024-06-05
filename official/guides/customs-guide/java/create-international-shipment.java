package customs;

import java.util.HashMap;

import com.easypost.service.EasyPostClient;
import com.easypost.exception.EasyPostException;

public class CreateInternationalShipment {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Map<String, Object> toAddressData = new HashMap<String, Object>();
        toAddressData.put("name", "Tim Canterbury");
        toAddressData.put("company", "Wernham Hogg");
        toAddressData.put("street1", "118 Clippenham Lane");
        toAddressData.put("city", "Slough");
        toAddressData.put("country", "GB");
        toAddressData.put("zip", "SL15BE");

        Map<String, Object> fromAddressData = new HashMap<String, Object>();
        fromAddressData.put("company", "EasyPost");
        fromAddressData.put("street1", "417 Montgomery Street");
        fromAddressData.put("street2", "5th Floor");
        fromAddressData.put("city", "San Francisco");
        fromAddressData.put("state", "CA");
        fromAddressData.put("country", "US");
        fromAddressData.put("zip", "94104");

        Map<String, Object> parcelData = new HashMap<String, Object>();
        parcelData.put("height", 3);
        parcelData.put("width", 6);
        parcelData.put("length", 9);
        parcelData.put("weight", 20);

        Map<String, Object> customsInfoData = new HashMap<String, Object>();
        customsInfoData.put("eel_pfc", "NOEEI 30.37(a)");
        customsInfoData.put("customs_certify", true);
        customsInfoData.put("customs_signer", "Steve Brule");
        customsInfoData.put("contents_type", "merchandise");
        customsInfoData.put("contents_explanation", "");
        customsInfoData.put("restriction_type", "none");

        List<Map<String, Object>> customsItemsData = new ArrayList<Map<String, Object>>();
        Map<String, Object> customsItem = new HashMap<String, Object>();
        customsItem.put("description", "T-shirt");
        customsItem.put("quantity", 2);
        customsItem.put("weight", 11);
        customsItem.put("value", 23);
        customsItem.put("hs_tariff_number", "654321");
        customsItem.put("origin_country", "US");
        customsItemsData.add(customsItem);
        customsInfoData.put("customs_items", customsItemsData);

        Map<String, Object> shipmentData = new HashMap<String, Object>();
        shipmentData.put("to_address", toAddressData);
        shipmentData.put("from_address", fromAddressData);
        shipmentData.put("parcel", parcelData);
        shipmentData.put("customs_info", customsInfoData);

        Shipment shipment = client.shipment.create(shipmentData);

        System.out.println("Shipment: " + shipment.getId());
    }
}
