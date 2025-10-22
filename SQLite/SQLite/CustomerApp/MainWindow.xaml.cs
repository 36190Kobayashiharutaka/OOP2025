using CustomerApp.Data;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System; // Exceptionを使うためにSystemが必要

namespace CustomerApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        // ★修正：未定義だったフィールドを宣言
        private CustomerRepository _repository;
        public ObservableCollection<Customer> Customers { get; set; }
        public Customer SelectedCustomer { get; set; }

        public MainWindow() {
            InitializeComponent();
            _repository = new CustomerRepository();

            // データを読み込み、画面のデータコンテキストに設定
            LoadData();
            this.DataContext = this;
        }

        private void LoadData() {
            // DBから全顧客情報を取得
            var customerList = _repository.GetCustomers();
            Customers = new ObservableCollection<Customer>(customerList);

            // 最初の顧客を選択状態にする（または新規Customerをセット）
            SelectedCustomer = Customers.FirstOrDefault() ?? new Customer();
        }

        // ① 新規登録ボタンの処理
        private void New_Click(object sender, RoutedEventArgs e) {
            // フォームを空にする（新規Customerを設定）
            SelectedCustomer = new Customer();
            // 画面のバインディングを更新
            this.DataContext = null;
            this.DataContext = this;
        }

        // ① 更新ボタンの処理（新規登録も兼ねる）
        private void Save_Click(object sender, RoutedEventArgs e) {
            if (SelectedCustomer == null || string.IsNullOrEmpty(SelectedCustomer.Name)) {
                MessageBox.Show("名前を入力してください。", "エラー");
                return;
            }

            // DBに保存（Idがあれば更新、なければ新規登録）
            _repository.SaveCustomer(SelectedCustomer);

            // データ再読み込み
            LoadData();

            // 画面のバインディングを更新
            this.DataContext = null;
            this.DataContext = this;

            MessageBox.Show("保存しました。", "成功");
        }

        // ① 削除ボタンの処理
        private void Delete_Click(object sender, RoutedEventArgs e) {
            if (SelectedCustomer == null || SelectedCustomer.Id == 0) {
                MessageBox.Show("削除する顧客を選択してください。", "エラー");
                return;
            }

            // 削除確認
            if (MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButton.YesNo) == MessageBoxResult.Yes) {
                _repository.DeleteCustomer(SelectedCustomer.Id);

                // データ再読み込み
                LoadData();

                // 画面のバインディングを更新
                this.DataContext = null;
                this.DataContext = this;

                MessageBox.Show("削除しました。", "成功");
            }
        }

        // 画像選択ボタンの処理
        private void SelectImage_Click(object sender, RoutedEventArgs e) {
            if (SelectedCustomer == null) return;

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";

            if (openFileDlg.ShowDialog() == true) {
                try {
                    // ★修正済み：Picture (byte[]) にファイルを読み込む
                    byte[] imageBytes = File.ReadAllBytes(openFileDlg.FileName);
                    SelectedCustomer.Picture = imageBytes;
                }
                catch (Exception ex) {
                    MessageBox.Show($"ファイルの読み込みに失敗しました: {ex.Message}", "エラー");
                }

                // Imageコントロールを強制的に更新するためにバインディングを再設定
                this.DataContext = null;
                this.DataContext = this;
            }
        }
    }
}