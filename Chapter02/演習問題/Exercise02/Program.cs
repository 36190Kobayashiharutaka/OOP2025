using Exercise02;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program {
    static void Main(string[] args) {

        Console.WriteLine("***　変換アプリ　***");
        Console.WriteLine("１：インチからメートル");
        Console.WriteLine("２：メートルからインチ");
        Console.Write("＞");
        int n = int.Parse(Console.ReadLine());

        Console.Write("はじめ：");
        int start = int.Parse(Console.ReadLine());

        Console.Write("おわり：");
        int end = int.Parse(Console.ReadLine());

        if (n == 1) {
            PrintInchToMeterList(start, end);
        } else {
            PrintMeterToInchList(start, end);
        }


        //インチからメートルへの対応表を出力
        static void PrintInchToMeterList(int start, int end) {
            for (int inch = start; inch <= end; inch++) {
                double meter = InchConverter.MeterToInch(inch);
                Console.WriteLine($"{inch}ih = {meter:0.0000}m");
            }
        }
        //メートルからインチへの対応表を出力
        static void PrintMeterToInchList(int start, int end) {
            for (int meter = start; meter <= end; meter++) {
                double inch = InchConverter.InchToMeter(meter);
                Console.WriteLine($"{meter}m = {inch:0.0000}ih");
            }
        }
    }
}