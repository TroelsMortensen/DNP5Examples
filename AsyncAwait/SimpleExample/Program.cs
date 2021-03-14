using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Method1Async();
        }

        private static async Task Method1Async()
        {
            Console.WriteLine("I'm doing some stuff..");
            Task<string> task = Method2Async();
            Console.WriteLine("I'm doing some other stuff, while the server is contacted");
            string result = await task;
            Console.WriteLine($"I now have the result: {result}");
        }

        private static async Task<string> Method2Async()
        {
            Console.WriteLine("Contacting server, hold on..");
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine("got response..");
            string result = await message.Content.ReadAsStringAsync();
            return result;
        }
    }
}