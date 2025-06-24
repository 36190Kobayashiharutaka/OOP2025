using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            // var today = new DateTime(2025,7,12);//日付
            //var now = DateTime.Now;//日付と時刻



            //Console.WriteLine($"Today:{today.Month}");
            //Console.WriteLine($"Now:{now}");


            //自分生年月日は何曜日かをプログラムを書いて調べる
 
            Console.WriteLine("西暦：");
            var year = int.Parse(Console.ReadLine());

            Console.WriteLine("月：");
            var month = int.Parse(Console.ReadLine());

            Console.WriteLine("日：");
            var day = int.Parse(Console.ReadLine());

            var birth = new DateTime(year, month, day);



            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var shortDayOfWeek = culture.DateTimeFormat.GetShortestDayName(birth.DayOfWeek);



            
        }
    }
}
