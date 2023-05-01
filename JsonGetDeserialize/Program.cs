using System.Net;
using System.Text.Json;
using JsonGetDeserialize.Models;

namespace JsonGetDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";
            string getResponse = Get(url);
            Data data = JsonSerializer.Deserialize<Data>(getResponse);
            
            Console.WriteLine(data.Completed);
            
        }

        static string Get(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd().Trim();
        }
    }
}