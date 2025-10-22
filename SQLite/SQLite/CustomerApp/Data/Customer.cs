using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerApp.Data {
    // 💡 修正箇所：internal を public に変更
    public class Customer {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public byte[] Picture { get; set; }
    }

    // CustomerRepository は元々 public なので問題なし
    public class CustomerRepository {
        private SQLiteConnection _database;
        private const string DB_NAME = "Customer.db";
        private readonly string DB_PATH;

        public CustomerRepository() {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            DB_PATH = Path.Combine(folder, DB_NAME);
            _database = new SQLiteConnection(DB_PATH);
            _database.CreateTable<Customer>();
        }

        // 全データの読み込み（Read）
        public List<Customer> GetCustomers() {
            return _database.Table<Customer>().ToList();
        }

        // 新規登録・更新（Create/Update）
        public int SaveCustomer(Customer customer) {
            if (customer.Id == 0) {
                return _database.Insert(customer); // 新規登録
            } else {
                return _database.Update(customer); // 更新
            }
        }

        // 削除（Delete）
        public int DeleteCustomer(int id) {
            return _database.Delete<Customer>(id);
        }
    }
}