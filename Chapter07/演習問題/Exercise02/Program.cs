
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
    new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
    new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
    new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
    new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
    new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
    new Book { Title = "私でも分かったASP.NET Core", Price = 3200, Pages = 453 },
    new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
};

            Console.WriteLine("7.2.1");
            Exercise1(books);

            Console.WriteLine("7.2.2");
            Exercise2(books);

            Console.WriteLine("7.2.3");
            Exercise3(books);

            Console.WriteLine("7.2.4");
            Exercise4(books);

            Console.WriteLine("7.2.5");
            Exercise5(books);

            Console.WriteLine("7.2.6");
            Exercise6(books);

            Console.WriteLine("7.2.7");
            Exercise7(books);
        }

        private static void Exercise1(List<Book> books) {
            books.Where(book => book.Title == "ワンダフル・C#ライフ")
            .ToList().ForEach(book => Console.WriteLine($"価格: {book.Price}円, ページ数: {book.Pages}ページ"));
        }

        private static void Exercise2(List<Book> books) {
            int cbook = books.Count(book => book.Title.Contains("C#"));
            Console.WriteLine(cbook);
        }

        private static void Exercise3(List<Book> books) {
            double averagePages = books.Where(book => book.Title.Contains("C#")).Average(book => book.Pages);
            Console.WriteLine(averagePages);
        }

        private static void Exercise4(List<Book> books) {
            Console.WriteLine(books.FirstOrDefault(book => book.Price >= 4000)?.Title);
        }

        private static void Exercise5(List<Book> books) {
            var maxPages = books.Where(book => book.Price < 4000).Max(book => book.Pages);

            Console.WriteLine(maxPages);
        }

        private static void Exercise6(List<Book> books) {
            books.Where(book => book.Pages >= 400).OrderByDescending(book => book.Price)
            .ToList().ForEach(book => Console.WriteLine($"タイトル: {book.Title}, 価格: {book.Price}円"));
        }

        private static void Exercise7(List<Book> books) {
            foreach (var book in books.Where(book => book.Title.Contains("C#") && book.Pages <= 500)) {
                Console.WriteLine($"- {book.Title}");
            }
        }
    }
}
