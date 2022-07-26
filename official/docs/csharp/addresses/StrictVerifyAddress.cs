using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Address address = await Address.Create(
    new Dictionary<string, object>() {
        { "street1", "417 MONTGOMERY ST" },
        { "street2", "FLOOR 5" },
        { "city", "SAN FRANCISCO" },
        { "state", "CA" },
        { "zip", "94104" },
        { "country", "US" },
        { "company", "EasyPost" },
        { "phone", "415-123-4567" },
        { "verify_strict", new List<booolean>() { true } }
    }
);

Console.Write(address);
