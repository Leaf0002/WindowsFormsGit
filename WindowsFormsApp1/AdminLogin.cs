using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class AdminLogin : System.Windows.Forms.Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }    

        /// <summary>
        /// パスワード表示、非表示用チェックボックス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayCheckedChanged(object sender, EventArgs e)
        {
            if (Display.Checked)
            {
                // チェックでパスワードを表示
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                // 未チェックでパスワードを隠す
                PasswordBox.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// ログイン確定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButtonClick(object sender, EventArgs e)
        {
            string id = IDBox.Text;
            string password = PasswordBox.Text;

            // root用のログイン
            if(id == "root" && password == "root")
            {
                Root_menu root = new Root_menu();
                root.Show();
                this.Hide();
                return;
            }

            // どちらかでも空の場合
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("IDとパスワードを入力してください。");
                return;
            }

            if (CheckLogin(id, password))
            {
                // ログイン成功でフォーム遷移
                Admin_menu admin_Menu = new Admin_menu();
                admin_Menu.Show();
                this.Hide();
            }
            else
            {
                // falseでかえってきた場合
                MessageBox.Show("ログイン失敗。IDまたはパスワードが正しくありません。");
            }
        }

        /// <summary>
        /// ログイン確認
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool CheckLogin(string username, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=admin.db"))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM t_admin WHERE Id = @Id AND Password = @Password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@Id", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    // 結果が帰ってきた場合trueで返す
                    if (result != null)
                    {
                        return Convert.ToInt32(result) > 0;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButtonClick(object sender, EventArgs e)
        {
            // 戻るボタンでメインメニューに戻る
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
