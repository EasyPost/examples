using System;
using EasyPost;

try
{
    Dictionary<string, object> parameters = new Dictionary<string, object> {
    { "verify_strict", True}
}
  await Address.Create(parameters);
}
catch (EasyPost.Exceptions.API.ApiError error)
{
    Console.Write(error.Code); // ADDRESS.VERIFY.FAILURE
}
