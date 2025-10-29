
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books.MaxBy(b => b.Price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var results = Library.Books
                          .GroupBy(b => b.PublishedYear)
                          .OrderBy(b => b.Key)
                          .Select(b => new {
                              PublishedYear = b.Key,
                              Count = b.Count(),
                          });

            foreach(var item in results) {
                Console.WriteLine($"{item.PublishedYear}:{item.Count}");
            }
        }

        private static void Exercise1_4() {
            var book = Library.Books
                .OrderByDescending(x => x.PublishedYear)
                .ThenByDescending(x => x.Price);
            foreach(var item in book) {
                Console.WriteLine($"{item.PublishedYear}年{item.Price}円{item.Title}");
            }
        }

        private static void Exercise1_5() {
            var categories = Library.Books
                    .Where(b => b.PublishedYear == 2022)
                    .Select(b => Library.Categories.First(c => c.Id == b.CategoryId).Name)
                    .Distinct();

            foreach (var c in categories)
                Console.WriteLine(c);
        }

        //模範解答
        //private static void Exercise1_5() {
        //var categoryName = Library.Books;
        //.Where(b => b.PublishedYear == 2022)
        //.Join(Library.Categories,
        // b => b.CategoryId,
        //c => c.Id,
        //(b, c) => c.Name)
        //.Distinct();
        //foreach(var name in categoryName) {
        //Console.WriteLine(name);
        //}


        private static void Exercise1_6() {
            foreach (var group in Library.Books
                    .GroupBy(b => Library.Categories.First(c => c.Id == b.CategoryId).Name)
                    .OrderBy(g => g.Key)) {
                Console.WriteLine($"＃ {group.Key}");
                foreach (var book in group)
                    Console.WriteLine(book.Title);
                Console.WriteLine();
            }
        }
        //模範解答
        //private static void Exercise1_6() {
            //var groups = Library.Books
                //.GroupJoin(Library.Categories,
                    //b => b.CategoryId,
                    //c => c.Id,
                    //(b, c) => new {
                        //CategoriesName = c.Name,
                        //b.Title
                    //})
                //.GroupBy(x => x.CategoriesName)
                //.OrderBy(g => g.Key);
            //foreach (var group in groups) {
                //Console.WriteLine($"＃ {group.Key}");
                //foreach (var book in group)
                    //Console.WriteLine($"   {book.Title}");
            //}
        //}

        private static void Exercise1_7() {
            foreach (var group in Library.Books
                    .Where(b => Library.Categories.First(c => c.Id == b.CategoryId).Name == "Development")
                    .GroupBy(b => b.PublishedYear)
                    .OrderBy(g => g.Key)) {
                Console.WriteLine($"＃ {group.Key}");
                foreach (var book in group)
                    Console.WriteLine($"    {book.Title}");
                Console.WriteLine();
            }
        }
        //模範解答
        //private static void Exercise1_7() {
            //var groups = Library.Categories
                //.Where(x => x.Name.Equals("Development"))
                //.Join(Library.Books,
                    //c => c.Id,
                    //b => b.CategoryId,
                    //(c, b) => new {
                        //b.Title,
                        //b.PublishedYear,
                    //})

                //.GroupBy(x => x.PublishedYear)
                //.OrderBy(x => x.Key);
            //foreach (var group in groups) {
                //Console.WriteLine($"＃ {group.Key}");
                //foreach (var book in group)
                    //Console.WriteLine($"   {book.Title}");
            //}
        //}
        

        private static void Exercise1_8() {

        }
    }
}
