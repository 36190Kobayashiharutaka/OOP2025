using System.Diagnostics;
using System.Windows.Forms;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
           var elapsed = await DoLongTimeWork(4000);
            toolStripStatusLabel1.Text = $"{elapsed}ミリ秒";
        }

        private async Task<long> DoLongTimeWork(int milliseconds) {
            var stopwatch = Stopwatch.StartNew();
            // 長時間かかる処理をシミュレート
            await Task.Run(() => {
                System.Threading.Thread.Sleep(milliseconds); // 指定された時間待機
            });
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        
    }
}
