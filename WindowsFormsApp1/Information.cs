using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Information : System.Windows.Forms.Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Employee-information.db"))
            {
                // データベースからデータを取得するためのデータセットとデータアダプタを作成
                var dataSet = new DataSet();
                var adapter = new SQLiteDataAdapter("SELECT Id, Name, Phone FROM t_employee", con);

                // データをデータセットにフィルする
                adapter.Fill(dataSet, "t_employee");

                // DataTableを作成
                var dataTable = dataSet.Tables["t_employee"];

                // 表示名の変更
                dataTable.Columns["Id"].Caption = " ID";
                dataTable.Columns["Name"].Caption = "名前";
                dataTable.Columns["Phone"].Caption = "電話番号";

                // DataGridViewにデータをバインド
                dataGridView1.DataSource = dataTable;

                dataGridView1.Dock = DockStyle.Fill;
            }           
        }
    }
}
