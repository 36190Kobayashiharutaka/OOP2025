using System;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();


            //本の平均金額を表示

            Console.WriteLine(books.Average(b => b.Price));

            //本のページ合計を表示

            Console.WriteLine(Books.GetBooks().Sum(book => book.Pages));

            //金額の安い書籍名と金額を表示

            var book = books.Where(x => x.Price == books.Min(b => b.Price));
            foreach(var item in book) {
                Console.WriteLine(item.Title + " : " + item.Price);
            }

            //ページが多い書籍名とページ数を表示

            books.Where(x => x.Pages == books.Max(b => b.Pages)).ToList().ForEach(x => Console.WriteLine($"{x.Title} : {x.Pages}ページ"));



            //タイトルに「物語」が含まれている書籍名をすべて表示
            Books.GetBooks().Where(book => book.Title.Contains("物語")).ToList().ForEach(book => Console.WriteLine(book.Title));


        }
    }
}
