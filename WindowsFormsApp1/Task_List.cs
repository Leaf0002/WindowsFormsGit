using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Task_List : Form
    {
        public Task_List()
        {
            InitializeComponent();

            // DataGridViewをフォームいっぱいに広げる
            DetaView.Dock = DockStyle.Fill;
            // DataGridView内のセルを編集不可に設定
            DetaView.ReadOnly = true;
        }

        private void Task_List_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Task_Management.db"))
            {
                var dataTable = new DataTable();
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_tasks", con);
                adapter.Fill(dataTable);
                DetaView.DataSource = dataTable;
                // DataGridViewAutoSizeColumnsMode.AllCellsはすべてのセルの内容に合わせて列の幅を調整するオプションです
                DetaView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // DataGridViewAutoSizeRowsMode.AllCellsはすべてのセルの内容に合わせて行の高さを調整するオプションです
                DetaView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                // フォントサイズを変更
                DetaView.DefaultCellStyle.Font = new Font("Arial", 12);

                DetaView.EditMode = DataGridViewEditMode.EditOnEnter;

            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
