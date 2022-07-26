using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> line_items = new Dictionary<string, object>() {
  {"title", "Square Reader"},
  {"barcode", "855658003251"}
};

Dictionary<string, object> form = new Dictionary<string, object>() {
  { "type", "return_packing_slip"},
  { "barcode", "RMA12345678900"},
  { "line_items", new List<Dictionary<string, object>>() 
    {line_items}
  },
  {"units", 8}
};
