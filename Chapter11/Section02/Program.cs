using System.Text.RegularExpressions;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var strings = new[] { "Micrisoft Windows", "windows", "Windows Server", "Windows" };

           //パターン完全一致している文字列の個数をカウント 
            var regex = new Regex(@"^(W|w)indows$");
            var count = strings.Count(s => regex.IsMatch(s));
            Console.WriteLine($"{count}行と一致");


            //パターンと完全一致している文字列を出力する



        }
    }
}
