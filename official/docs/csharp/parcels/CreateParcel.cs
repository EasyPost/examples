using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Parcel parcel = await Parcel.Create(new Dictionary<string, object>() {
    { "length", 20.2 },
    { "width", 10.9 },
    { "height", 5 },
    {  "weight", 65.9 }
});

Console.Write(parcel);
