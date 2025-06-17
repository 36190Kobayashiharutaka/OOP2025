namespace DistamceConverter {

    // Program クラスを定義（エントリーポイントを含む）
    internal class Program {

        // Mainメソッド：アプリケーションのエントリーポイント
        static void Main(string[] args) {

            // コマンドライン引数の2番目と3番目を整数として取得（開始と終了の範囲）
            int f = int.Parse(args[1]);
            int e = int.Parse(args[2]);

            // コマンドライン引数の個数と最初の引数の値に応じて処理を分岐
            if (args.Length >= 1 && args[0] == "-tom") {
                // -tom が指定された場合、フィートからメートルへの対応表を表示
                PrintFeetToMeterList(f, e);
            } else if (args.Length >= 1 && args[0] == "-tof") {
                // -tof が指定された場合、メートルからフィートへの対応表を表示
                PrintMeterToFeetList(f, e);
            } else {
                // それ以外の場合、デフォルトでフィートからメートルへの対応表を表示
                PrintFeetToMeterList(f, e);
            }
        }

        // 指定範囲のフィート値をメートルに変換して表示するメソッド
        static void PrintFeetToMeterList(int f, int e) {
            // f から e までの各フィート値に対して繰り返し処理
            for (int feet = f; feet <= e; feet++) {
                // フィートをメートルに変換
                double meter = FeetConverter.ToMeter(feet);
                // 結果を小数点以下4桁で表示
                Console.WriteLine($"{feet}ft = {meter:0.0000}");
            }
        }

        // 指定範囲のメートル値をフィートに変換して表示するメソッド
        static void PrintMeterToFeetList(int f, int e) {
            // f から e までの各メートル値に対して繰り返し処理
            for (int meter = f; meter <= e; meter++) {
                // メートルをフィートに変換
                double feet = FeetConverter.FromMeter(meter);
                // 結果を小数点以下4桁で表示
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }
    }
}
