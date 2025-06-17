using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    // 売上集計を行うクラス SalesCounter
    public class SalesCounter {
        // 売上データのリスト（Saleオブジェクトの列挙体）
        private readonly IEnumerable<Sale> _sales;

        // コンストラクタ：ファイルパスを受け取って、売上データを読み込む
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);  // 指定されたファイルパスから売上データを読み込む
        }

        // 店舗別の売上を集計して返すメソッド
        public IDictionary<string, int> GetPerStoreSales() {
            // 店舗名をキーに、売上金額を値とするソート済み辞書を生成
            var dict = new SortedDictionary<string, int>();

            // 売上データを繰り返し処理して集計
            foreach (Sale sale in _sales) {
                // 既に辞書に店舗名があれば、金額を加算
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    // 店舗名がなければ新たに追加
                    dict[sale.ShopName] = sale.Amount;
            }

            // 店舗別売上集計結果を返す
            return dict;
        }

        // 売上データをファイルから読み込み、Saleオブジェクトの列挙体を返す静的メソッド
        public static IEnumerable<Sale> ReadSales(string filePath) {
            // 売上データを入れるリストを作成
            var sales = new List<Sale>();

            // 指定されたファイルを一行ずつ読み込む
            var lines = File.ReadAllLines(filePath);

            // 読み込んだ行数分繰り返し処理
            foreach (var line in lines) {
                // 1行をカンマ区切りで分割
                var items = line.Split(',');

                // Saleオブジェクトを作成
                var sale = new Sale() {
                    ShopName = items[0],  // 店舗名
                    ProductCategory = items[1],  // 商品カテゴリ
                    Amount = int.Parse(items[2])  // 売上金額（文字列を整数に変換）
                };

                // 作成したSaleオブジェクトをリストに追加
                sales.Add(sale);
            }

            // すべてのSaleオブジェクトを返す
            return sales;
        }
    }
}
