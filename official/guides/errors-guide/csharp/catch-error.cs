using System;
using EasyPost;

try
{
    Dictionary<string, object> parameters = new Dictionary<string, object> {
    { "verify_strict", True}
}
  await Address.Create(parameters);
}
catch (EasyPost.HttpException e)
{
    Console.Write(e.Code); // ADDRESS.VERIFY.FAILURE
}
