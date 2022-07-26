using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.RetrieveMe();

string color = "#303F9F";

Dictionary<string, object> brand = new Dictionary<string, object>()
{
    {
        "color", color
    }
};

await user.Update(new Dictionary<string, object>(){
    { "color", color }
});

Console.Write(brand);
