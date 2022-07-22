using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> listParams = new Dictionary<string, object>() {
  { "page_size", 5 }
};

InsuranceCollection insuranceCollection = await Insurance.All(listParams);
InsuranceCollection nextInsuranceCollection = await insuranceCollection.Next();
