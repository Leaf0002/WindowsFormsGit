using System;

namespace WindowsFormsApp1
{
    public partial class Admin_menu : System.Windows.Forms.Form
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// タスク編集フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskEditClick(object sender, EventArgs e)
        {
            Task_Edit edit = new Task_Edit();
            edit.Show();
            this.Hide();
        }

        /// <summary>
        /// ユーザー登録フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationClick(object sender, EventArgs e)
        {
            SaveLoginForm.BeforForm = "admin";
            Root_Add add = new Root_Add();
            add.Show();
            this.Hide();
        }

        /// <summary>
        /// タスク登録フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskRegistClick(object sender, EventArgs e)
        {
            Task_Regist regist = new Task_Regist();
            regist.Show();
            this.Hide();
        }

        /// <summary>
        /// ログアウトボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutClick(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
