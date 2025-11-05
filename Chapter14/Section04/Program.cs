using System.Threading.Tasks;

namespace Section04 {
    internal class Program {
        static async Task Main(string[] args) {
            HttpClient hc = new HttpClient();
            await GetHtmExample(hc);

        }

        static async Task GetHtmExample(HttpClient httpClient) {
            var url = "https://www.google.com/?hl=ja";
            var text = await httpClient.GetStringAsync(url);
            Console.WriteLine(text);
        }

    }
}
