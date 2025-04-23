using Exercise02;
using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("***　変換アプリ　***");
        Console.WriteLine("１：ヤードからメートル");
        Console.WriteLine("２：メートルからヤード");
        Console.Write("＞");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1) {
            Console.WriteLine();
            Console.Write("変換前(ヤード)：");
            int yard = int.Parse(Console.ReadLine());
            double meter = YardConverter.YardToMeter(yard);
            Console.WriteLine($"変換後(メートル):{meter:0.000}");
        } else if (choice == 2) {
            Console.WriteLine();
            Console.Write("変換前(メートル)：");
            int meter = int.Parse(Console.ReadLine());
            double yard = YardConverter.MeterToYard(meter);
            Console.WriteLine($"変換後(ヤード):{yard:0.000}");
        } else {
            Console.WriteLine("無効な選択です。");
        }
    }
}
