using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Task_Edit : System.Windows.Forms.Form
    {
        private string column;

        public Task_Edit()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        /// <summary>
        /// 更新決定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Button_Click(object sender, EventArgs e)
        {
            // textboxの内容を取得
            string updatedText = Update_Text.Text;

            // textboxが空の場合はメッセージを表示して処理を中止
            if (string.IsNullOrEmpty(updatedText))
            {
                MessageBox.Show("更新するテキストを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 選択された行のデータを取得
            DataGridViewRow selectedRow = DateView.CurrentRow;

            // 選択された行のIDを取得
            if (selectedRow != null)
            {
                int selectedID = Convert.ToInt32(selectedRow.Cells["Number"].Value);

                // データベースを更新するSQLクエリ
                string updateQuery = $"UPDATE t_tasks SET {SGColumnName} = @UpdatedText WHERE Number = @SelectedID";

                using (SQLiteConnection connection = new SQLiteConnection("Data Source=Task_Management.db"))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        // パラメーターの設定
                        command.Parameters.AddWithValue("@UpdatedText", updatedText);
                        command.Parameters.AddWithValue("@SelectedID", selectedID);

                        // クエリの実行
                        command.ExecuteNonQuery();
                    }
                }
                // データベースの変更を反映するためにDataGridViewを再読み込み
                LoadDataIntoDataGridView();
            }
        }

        /// <summary>
        /// データグリッドビューの読み込み
        /// 読み込み時に呼び出す
        /// </summary>
        private void LoadDataIntoDataGridView()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Task_Management.db"))
            {
                var dataTable = new DataTable();
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_tasks", con);
                adapter.Fill(dataTable);
                DateView.DataSource = dataTable;
                // DataGridViewAutoSizeColumnsMode.AllCellsはすべてのセルの内容に合わせて列の幅を調整するオプションです
                DateView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // DataGridViewAutoSizeRowsMode.AllCellsはすべてのセルの内容に合わせて行の高さを調整するオプションです
                DateView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                // フォントサイズを変更
                DateView.DefaultCellStyle.Font = new Font("Arial", 12);

                DateView.EditMode = DataGridViewEditMode.EditOnEnter;

                // あるいは、特定の列全体を編集可能にする場合
                DateView.Columns["Name"].ReadOnly = false;
            }
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnClick(object sender, EventArgs e)
        {
            Admin_menu menu = new Admin_menu();
            menu.Show();
            this.Hide();
        }

        /// <summary>
        /// データグリッドビュークリック時にtextboxにセルの内容をコピー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // クリックされたセルがヘッダーの場合は処理をスキップ
            if (e.RowIndex == -1)
                return;

            // 選択された行のインデックスを取得
            int rowIndex = e.RowIndex;

            // 選択された行から各セルの値を取得
            DataGridViewRow selectedRow = DateView.Rows[rowIndex];

            // 選択されたセルの列番号を取得
            int selectedColumnIndex = DateView.CurrentCell.ColumnIndex;

            // 列番号から列名を取得
            string ColumnName = GetColumnName(selectedColumnIndex);

            // セルの値をtextboxに表示
            Update_Text.Text = selectedRow.Cells[ColumnName].Value.ToString();

            SGColumnName = ColumnName;
        }

        /// <summary>
        /// コラム名の取得に使うメソッド
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string GetColumnName(int index)
        {
            switch (index)
            {
                case 1:
                    return "Name";
                case 2:
                    return "Manager";
                case 3:
                    return "Inportance";
                case 4:
                    return "Start";
                case 5:
                    return "Finish";
                case 6:
                    return "DueDate";
                case 7:
                    return "Stats";
                case 8:
                    return "Note";
                default:
                    return "shine";
            }
        }
       private string SGColumnName
        {
            get { return column; }
            set { column = value; }
        } 
    }
}
