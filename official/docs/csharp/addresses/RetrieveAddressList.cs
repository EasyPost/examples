using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

AddressCollection addressCollection = await Address.All(new Dictionary<string, object>()
    {"page_size", 5}
);

Console.Write(addressCollection);
