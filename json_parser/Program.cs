using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace json_parser
{
  class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }

    public override string ToString()
    {
      return $"ID: {Id}, Name: {Name}";
    }

  }
  class Program
  {
    private static readonly HttpClient client = new HttpClient();

    public static void Main(string[] args)
    {
      var response = GetResponse("https://jsonplaceholder.typicode.com/users").Result;
      Console.WriteLine(response);
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