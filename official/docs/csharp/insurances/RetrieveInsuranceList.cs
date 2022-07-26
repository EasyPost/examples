using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

InsuranceCollection insuranceCollection = await Insurance.All(new Dictionary<string, object>(){
  { "page_size", 5 }
});

Console.Write(insuranceCollection);
