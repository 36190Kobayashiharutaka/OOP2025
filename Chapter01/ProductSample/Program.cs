namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karintou = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(250, "daihuku", 150);
            //かりんとう

            //税抜きの価格を表示【かりんとうの税抜き価格は○○円です】

            Console.WriteLine(karintou.Name + "税抜きの価格は" + karintou.Price + "円です");

            //消費税額の表示【かりんとうの消費税額は○○円です】

            Console.WriteLine(karintou.Name + "消費税額は" + karintou.GetTax() + "円です");

            //税込み価格の表示【かりんとうの税込み価格は○○円です】
            Console.WriteLine(karintou.Name + "税込み価格は" + karintou.GetPriceIncludingTax() + "円です");

            //大福

            //税抜きの価格を表示【大福の税抜き価格は○○円です】

            Console.WriteLine(daihuku.Name + "税抜きの価格は" + daihuku.Price + "円です");

            //消費税額の表示【大福の消費税額は○○円です】

            Console.WriteLine(daihuku.Name + "消費税額は" + daihuku.GetTax() + "円です");

            //税込み価格の表示【大福の税込み価格は○○円です】
            Console.WriteLine(daihuku.Name + "税込み価格は" + daihuku.GetPriceIncludingTax() + "円です");

        }
    }
}
