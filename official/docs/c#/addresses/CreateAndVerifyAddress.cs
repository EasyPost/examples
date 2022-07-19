using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Address address = Address.CreateAndVerify(
    new Dictionary<string, object>() {
        { "street1", "417 montgomery street" },
        { "street2", "FL 5" },
        { "city", "San Francisco" },
        { "state", "CA" },
        { "zip", "94104" },
        { "country", "US" },
        { "company", "EasyPost" },
        { "phone", "415-123-4567" }
    }
);
