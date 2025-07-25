
namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btRssGet = new Button();
            lbTitles = new ListBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            cbUrl = new ComboBox();
            GoBack = new Button();
            GoForward = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(525, 12);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(94, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.DrawMode = DrawMode.OwnerDrawFixed;
            lbTitles.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 21;
            lbTitles.Location = new Point(12, 54);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(607, 130);
            lbTitles.TabIndex = 2;
            lbTitles.DrawItem += lbTitles_DrawItem;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = SystemColors.ControlLightLight;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 190);
            webView21.Name = "webView21";
            webView21.Size = new Size(607, 465);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // cbUrl
            // 
            cbUrl.FormattingEnabled = true;
            cbUrl.Location = new Point(120, 12);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(399, 23);
            cbUrl.TabIndex = 4;
            cbUrl.SelectedIndexChanged += tbUrl_SelectedIndexChanged;
            // 
            // GoBack
            // 
            GoBack.Location = new Point(15, 1);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(78, 23);
            GoBack.TabIndex = 5;
            GoBack.Text = "戻る";
            GoBack.UseVisualStyleBackColor = true;
            GoBack.Click += GoBack_Click;
            // 
            // GoForward
            // 
            GoForward.Location = new Point(15, 30);
            GoForward.Name = "GoForward";
            GoForward.Size = new Size(78, 23);
            GoForward.TabIndex = 6;
            GoForward.Text = "次へ";
            GoForward.UseVisualStyleBackColor = true;
            GoForward.Click += GoForward_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 667);
            Controls.Add(GoForward);
            Controls.Add(GoBack);
            Controls.Add(cbUrl);
            Controls.Add(webView21);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "RSSリーダー";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        private void lbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            throw new NotImplementedException();
        }

        #endregion
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ComboBox cbUrl;
        private Button GoBack;
        private Button GoForward;
    }
}
