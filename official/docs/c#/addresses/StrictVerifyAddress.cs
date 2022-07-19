using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

try {
    Address address = await Address.Create(
        new Dictionary<string, object>() {
            { "street1", "UNDELIEVRABLE ST" },
            { "street2", "FLOOR 5" },
            { "city", "SAN FRANCISCO" },
            { "state", "CA" },
            { "zip", "94104" },
            { "country", "US" },
            { "company", "EasyPost" },
            { "phone", "415-123-4567" },
            { "verifications", new List<string>() { "delivery" } }
        }
    );
} catch(HttpException e) {
    Console.WriteLine(e.code);
    Console.WriteLine(e.http_status);
    Console.WriteLine(e.message);
}
