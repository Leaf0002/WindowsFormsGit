using System;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Root_Update : System.Windows.Forms.Form
    {
        public Root_Update()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 更新決定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Admin.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {

                    SQLiteCommand cmd = con.CreateCommand();

                    //挿入
                    cmd.CommandText = "UPDATE t_admin SET Name = @Name, Password = @Password WHERE ID = @Id";
                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Password", System.Data.DbType.String);
                    cmd.Parameters.Add("ID", System.Data.DbType.String);
                    // データ追加
                    cmd.Parameters["Name"].Value = NameBox.Text;
                    cmd.Parameters["Password"].Value = PasswordBox.Text;
                    cmd.Parameters["ID"].Value = IDBox.Text;

                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();

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
            Root_menu root = new Root_menu();
            root.Show();
            this.Hide();
        }
    }
}
