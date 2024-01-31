using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Task_Regist : System.Windows.Forms.Form
    {
        public Task_Regist()
        {
            InitializeComponent();

            // コンボボックスの要素追加
            Importance.Items.Add("高");
            Importance.Items.Add("中");
            Importance.Items.Add("小");
        }

        /// <summary>
        /// 登録決定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaskName.Text) || string.IsNullOrEmpty(Manager.Text) || string.IsNullOrEmpty(Importance.Text) ||
                string.IsNullOrEmpty(Startday.Text) || string.IsNullOrEmpty(Due_date.Text))
            {
                MessageBox.Show("備考以外で空白は使用できません");
                return;
            }
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Task_Management.db"))
            {
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //挿入
                    cmd.CommandText = "INSERT INTO t_tasks (Name, Manager, Inportance, Start, Finish, Duedate, Status, Note) " +
                        "VALUES (@Name, @Manager, @Inportance, @Start, @Finish, @Duedate, @Status, @Note)";
                    //データ追加
                    cmd.Parameters.AddWithValue("Name", TaskName.Text);
                    cmd.Parameters.AddWithValue("Manager", Manager.Text);
                    cmd.Parameters.AddWithValue("Inportance", Importance.Text);
                    cmd.Parameters.AddWithValue("Start", Startday.Text);
                    cmd.Parameters.AddWithValue("Finish", "未");
                    cmd.Parameters.AddWithValue("Duedate", Due_date.Text);
                    cmd.Parameters.AddWithValue("Status", "未着手");
                    cmd.Parameters.AddWithValue("Note", Note.Text);

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
            Admin_menu admin_Menu = new Admin_menu();
            admin_Menu.Show();
            this.Hide();
        }
    }
}
//using (var con = new SQLiteConnection("Data Source=Task_Management.db"))
//{
//    con.Open();

//    using (SQLiteCommand command = con.CreateCommand())
//    {
//        command.CommandText =
//            "create table t_tasks(Number INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Manager TEXT, Inportance TEXT CHECK(Inportance IN ('高', '中', '小')), " +
//            "Start TEXT, Finish TEXT, Duedate TEXT, Status TEXT CHECK(Status IN ('未着手', '進行中', '完了')), Note TEXT)";
//        command.ExecuteNonQuery();
//    }
//    con.Close();
//}
