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

            var str = birth.ToString("ggyy年M月d日", culture);
            var shortDayOfWeek = culture.DateTimeFormat.GetShortestDayName(birth.DayOfWeek);
            
            Console.WriteLine(str + birth.ToString("ddd曜日", culture));

            //生まれてから○○○○日目です。
            TimeSpan diff;
            while (true) {
                diff = DateTime.Now - birth;
                Console.WriteLine($"r{diff.TotalDays}日 {diff.TotalHours}時間 {diff.TotalMinutes}分");//生まれてからの経過秒数

            }
            //あなたは○○歳です！
            int age = GatAge(birth, DateTime.Today);
            Console.WriteLine(age + "歳");
            //一月一日から何日目か？

            static int GatAge(DateTime brithday,DateTime targetDay) {
                var age = targetDay.Year - brithday.Year;
                if (targetDay < brithday.AddYears(age)) {
                    age--;
                }
                return age;
            }
            
        }
    }
}
