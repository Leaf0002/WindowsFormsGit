using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Root_Add : System.Windows.Forms.Form
    {
        public Root_Add()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 追加決定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Admin.db"))
            {
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    //挿入♡
                    cmd.CommandText = "INSERT INTO t_admin (Name, Password) VALUES ( @Name, @Password)";
                    //パラメーター
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Password", System.Data.DbType.String);
                    //データ追加
                    cmd.Parameters["Name"].Value = NameBox.Text;
                    cmd.Parameters["Password"].Value = PasswordBox.Text;

                    cmd.ExecuteNonQuery();
                    //結果にコミット
                    trans.Commit();

                }
            }
            MessageBox.Show("追加に成功しました");
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButtonClick(object sender, EventArgs e)
        {
            if(SaveLoginForm.BeforForm == "root")
            {
                Root_menu root = new Root_menu();
                root.Show();
                this.Hide();
            }
            if(SaveLoginForm.BeforForm == "admin")
            {
                Admin_menu menu = new Admin_menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
