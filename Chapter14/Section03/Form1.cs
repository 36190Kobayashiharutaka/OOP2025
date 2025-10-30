using System.Diagnostics;
using System.Windows.Forms;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            var elapsed = await Task.Run(()=>DoLongTimeWork());
            toolStripStatusLabel1.Text = "�I��";
        }
        private long DoLongTimeWork() {
            // �����Ԃ����鏈�����V�~�����[�g
            var sw = Stopwatch.StartNew();

            System.Threading.Thread.Sleep(5000); // 5�b�ҋ@
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
