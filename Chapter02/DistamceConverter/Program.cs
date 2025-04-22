namespace DistamceConverter {
    internal class Program {
        //コマンドライン引数で指定された範囲のフィートとメートルの対応表を出力する
        static void Main(string[] args) {

            //フィートからメートルへの対応表を表示
            int f = int.Parse(args[1]);
            int e = int.Parse(args[2]);

            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(f, e);
            } else {
                PrintFeetToMeterList(f, e);
            }
            //フィートからメートルへの対応表を出力
            static void PrintFeetToMeterList(int f, int e) {
                FeetConverter fc = new FeetConverter();
                for (int feet = f; feet <= e; feet++) {
                    double meter = fc.ToMeter(feet);
                    Console.WriteLine($"{feet}ft = {meter:0.0000}");
                }
            }
            //メートルかフィートへの対応表を出力
            static void PrintMeterToFeetList(int f, int e) {
                FeetConverter fc = new FeetConverter();

                for (int meter = f; meter <= e; meter++) {
                    double feet = fc.FromMeter(meter);
                    Console.WriteLine($"{meter}m = {feet:0.0000}ft");
                }
            }
        }
    }
}
