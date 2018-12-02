using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace json_parser
{
  class Program
  {
    private static readonly HttpClient client = new HttpClient();

    public static void Main(string[] args)
    {
      var response = GetResponse("https://jsonplaceholder.typicode.com/users").Result.ToString();

      List<User> users = JsonConvert.DeserializeObject<List<User>>(response);

      foreach (var item in users)
      {
        Console.WriteLine(item);
      }

      Console.ReadLine();
    }

    public static async Task<string> GetResponse(string url)
    {
      HttpResponseMessage response = await client.GetAsync(url);
      response.EnsureSuccessStatusCode();

      string responseBody = await response.Content.ReadAsStringAsync();
      return responseBody;
    }
  }
}