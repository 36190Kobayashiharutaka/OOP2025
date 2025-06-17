namespace SalesCalculator {
    // プログラムのエントリーポイントを含むクラス Program
    internal class Program {
        // Main メソッド: アプリケーションの実行開始地点
        static void Main(string[] args) {
            // "sales.csv" というファイルを読み込んで、SalesCounter オブジェクトを作成
            var sales = new SalesCounter(@"date\sales.csv");

            // 店舗別の売上集計結果を取得
            var amountsPerStore = sales.GetPerStoreSales();

            // 店舗ごとの売上金額を出力
            foreach (var obj in amountsPerStore) {
                // obj.Key は店舗名、obj.Value はその店舗の売上合計
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }
        }
    }
}
