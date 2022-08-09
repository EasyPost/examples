using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Address address = await Address.Create(
    new Dictionary<string, object>() {
        { "street1", "417 Montgomery Street" },
        { "street2", "5" },
        { "city", "SF" },
        { "state", "CA" },
        { "zip", "94104" },
        { "country", "US" },
        { "company", "EasyPost" },
        { "phone", "415-123-4567" },
        { "verify", true }
    }
);

Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
