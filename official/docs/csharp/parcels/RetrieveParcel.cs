using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Parcel parcel = await Parcel.Retrieve("prcl_...");

Console.WriteLine(JsonConvert.SerializeObject(parcel, Formatting.Indented));
