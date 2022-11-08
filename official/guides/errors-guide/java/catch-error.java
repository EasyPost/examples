import com.easypost.model.Shipment;

try {
  Map<String, Object> address = new HashMap<String, Object>();
  ...

  address.put("verify_strict", true);

  Address.create(address);
} catch (EasyPostException e) {
  System.err.println(e.getMessage());
}
