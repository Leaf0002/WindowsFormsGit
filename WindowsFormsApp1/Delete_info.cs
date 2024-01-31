using System;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Root_Delete : System.Windows.Forms.Form
    {
        public Root_Delete()
        {
            InitializeComponent();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Admin.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {

                    SQLiteCommand cmd = con.CreateCommand();

                    //挿入
                    cmd.CommandText = "DELETE FROM t_admin WHERE Id = @Id";

                    cmd.Parameters.Add("Id", System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["Id"].Value = int.Parse(IDBox.Text);

                    cmd.ExecuteNonQuery();
                    //結果にコミット
                    trans.Commit();

                }
            }
        }

        private void ReturnButtonClick(object sender, EventArgs e)
        {
            Root_menu root_Menu = new Root_menu();
            root_Menu.Show();
            this.Hide();
        }
    }
}
