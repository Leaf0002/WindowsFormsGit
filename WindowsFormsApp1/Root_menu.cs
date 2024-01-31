using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Root_menu : System.Windows.Forms.Form
    {
        public Root_menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ユーザー削除フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdimnDeleteClick(object sender, EventArgs e)
        {
            Root_Delete delete = new Root_Delete();
            delete.Show();
            this.Hide();
        }

        /// <summary>
        /// ユーザー追加フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminAddClick(object sender, EventArgs e)
        {
            SaveLoginForm.BeforForm = "root";
            Root_Add add = new Root_Add();
            add.Show();
            this.Hide();
        }

        /// <summary>
        /// ユーザー更新フォーム移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminUpdataClick(object sender, EventArgs e)
        {
            Root_Update update = new Root_Update();
            update.Show();
            this.Hide();
        }

        /// <summary>
        /// タスク編集フォーム移動
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
        /// データ表示ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateViewButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Admin.db"))
            {
                var dataTable = new DataTable();
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_admin", con);
                adapter.Fill(dataTable);
                DetaView.DataSource = dataTable;
            }
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
