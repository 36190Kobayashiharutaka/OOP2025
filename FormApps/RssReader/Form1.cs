using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        Dictionary<string, string> rssUrlDict = new Dictionary<string, string>(){
            {"あ","https://ja.wikipedia.org/wiki/%E3%81%82" },
            {"い","https://ja.wikipedia.org/wiki/%E3%81%84" },
            {"う","https://ja.wikipedia.org/wiki/%E3%81%86" },
            {"え","https://ja.wikipedia.org/wiki/%E3%81%88" },
            {"お","https://ja.wikipedia.org/wiki/%E3%81%8A" },
            {"か","https://ja.wikipedia.org/wiki/%E3%81%8B" },
            {"き","https://ja.wikipedia.org/wiki/%E3%81%8D" },
            {"く","https://ja.wikipedia.org/wiki/%E3%81%8F" },
            {"け","https://ja.wikipedia.org/wiki/%E3%81%91" },
        };


        public Form1() {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e) {
            cbUrl.DataSource = rssUrlDict.Select(k => k.Key).ToList();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {

            using (var hc = new HttpClient()) {

                string xml = await hc.GetStringAsync(cbUrl.Text);
                XDocument xdoc = XDocument.Parse(xml);

                //RSSを解析して必要な要素を取得
                items = xdoc.Root.Descendants("item")
                    .Select(x =>
                        new ItemData {
                            Title = (string)x.Element("title"),
                            Link = (string)x.Element("link"),
                        }).ToList();


                //リストボックスへタイトルを表示
                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "データなし"));

            }
        }
        private string getRssUrl(string str) {

            if (rssUrlDict.ContainsKey(str)) {
                return rssUrlDict[str];
            }
            return str;
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            webView21.Source = new Uri(items[lbTitles.SelectedIndex].Link);
        }

        private void tbUrl_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void GoBack_Click(object sender, EventArgs e) {
            webView21.GoBack();
        }

        private void GoForward_Click(object sender, EventArgs e) {
            webView21.GoForward();
        }

        private void LbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            var idx = e.Index;                                                      //描画対象の行
            if (idx == -1) return;                                                  //範囲外なら何もしない
            var sts = e.State;                                                      //セルの状態
            var fnt = e.Font;                                                       //フォント
            var _bnd = e.Bounds;                                                    //描画範囲(オリジナル)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //描画範囲(描画用)
            var txt = (string)lbTitles.Items[idx];                                  //リストボックス内の文字
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //文字色
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //選択行か
            var odd = (idx % 2 == 1);                                               //奇数行か
            var fore = Brushes.WhiteSmoke;                                         //偶数行の背景色
            var bak = Brushes.AliceBlue;                                           //奇数行の背景色

            e.DrawBackground();                                                     //背景描画

            //奇数項目の背景色を変える（選択行は除く）
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //文字を描画
            e.Graphics.DrawString(txt, fnt, bsh, bnd);
        }
    }
}
