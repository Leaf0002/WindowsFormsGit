using System;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ユーザーログインフォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        /// <summary>
        /// タスク一覧フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskList_Click(object sender, EventArgs e)
        {
            Task_List tasklist = new Task_List();
            tasklist.Show();
            this.Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=Admin.db"))
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    //挿入
                    cmd.CommandText = "create table t_admin(ID INTEGER PRIMARY KEY, Name TEXT, Password TEXT)";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
