
namespace WindowsFormsApp1
{
    partial class Root_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdimnDelete = new System.Windows.Forms.Button();
            this.TaskEdit = new System.Windows.Forms.Button();
            this.AdminAdd = new System.Windows.Forms.Button();
            this.AdminUpdata = new System.Windows.Forms.Button();
            this.DetaView = new System.Windows.Forms.DataGridView();
            this.DateViewButton = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetaView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdimnDelete
            // 
            this.AdimnDelete.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AdimnDelete.Location = new System.Drawing.Point(234, 143);
            this.AdimnDelete.Name = "AdimnDelete";
            this.AdimnDelete.Size = new System.Drawing.Size(178, 61);
            this.AdimnDelete.TabIndex = 0;
            this.AdimnDelete.Text = "ユーザー削除";
            this.AdimnDelete.UseVisualStyleBackColor = true;
            this.AdimnDelete.Click += new System.EventHandler(this.AdimnDeleteClick);
            // 
            // TaskEdit
            // 
            this.TaskEdit.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaskEdit.Location = new System.Drawing.Point(235, 275);
            this.TaskEdit.Name = "TaskEdit";
            this.TaskEdit.Size = new System.Drawing.Size(177, 62);
            this.TaskEdit.TabIndex = 1;
            this.TaskEdit.Text = "タスク編集";
            this.TaskEdit.UseVisualStyleBackColor = true;
            this.TaskEdit.Click += new System.EventHandler(this.TaskEditClick);
            // 
            // AdminAdd
            // 
            this.AdminAdd.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AdminAdd.Location = new System.Drawing.Point(12, 143);
            this.AdminAdd.Name = "AdminAdd";
            this.AdminAdd.Size = new System.Drawing.Size(179, 61);
            this.AdminAdd.TabIndex = 2;
            this.AdminAdd.Text = "ユーザー追加";
            this.AdminAdd.UseVisualStyleBackColor = true;
            this.AdminAdd.Click += new System.EventHandler(this.AdminAddClick);
            // 
            // AdminUpdata
            // 
            this.AdminUpdata.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AdminUpdata.Location = new System.Drawing.Point(12, 274);
            this.AdminUpdata.Name = "AdminUpdata";
            this.AdminUpdata.Size = new System.Drawing.Size(178, 63);
            this.AdminUpdata.TabIndex = 3;
            this.AdminUpdata.Text = "ユーザー情報変更";
            this.AdminUpdata.UseVisualStyleBackColor = true;
            this.AdminUpdata.Click += new System.EventHandler(this.AdminUpdataClick);
            // 
            // DetaView
            // 
            this.DetaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetaView.Location = new System.Drawing.Point(453, 96);
            this.DetaView.Name = "DetaView";
            this.DetaView.RowHeadersWidth = 51;
            this.DetaView.RowTemplate.Height = 24;
            this.DetaView.Size = new System.Drawing.Size(309, 318);
            this.DetaView.TabIndex = 4;
            // 
            // DateViewButton
            // 
            this.DateViewButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DateViewButton.Location = new System.Drawing.Point(592, 33);
            this.DateViewButton.Name = "DateViewButton";
            this.DateViewButton.Size = new System.Drawing.Size(159, 43);
            this.DateViewButton.TabIndex = 5;
            this.DateViewButton.Text = "データ表示";
            this.DateViewButton.UseVisualStyleBackColor = true;
            this.DateViewButton.Click += new System.EventHandler(this.DateViewButtonClick);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(109, 36);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "ログアウト";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.LogoutClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(226, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "管理者画面";
            // 
            // Root_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.DateViewButton);
            this.Controls.Add(this.DetaView);
            this.Controls.Add(this.AdminUpdata);
            this.Controls.Add(this.AdminAdd);
            this.Controls.Add(this.TaskEdit);
            this.Controls.Add(this.AdimnDelete);
            this.Name = "Root_menu";
            this.Text = "Root_menu";
            ((System.ComponentModel.ISupportInitialize)(this.DetaView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdimnDelete;
        private System.Windows.Forms.Button TaskEdit;
        private System.Windows.Forms.Button AdminAdd;
        private System.Windows.Forms.Button AdminUpdata;
        private System.Windows.Forms.DataGridView DetaView;
        private System.Windows.Forms.Button DateViewButton;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label1;
    }
}