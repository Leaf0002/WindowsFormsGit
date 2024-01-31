
namespace WindowsFormsApp1
{
    partial class Admin_menu
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
            this.TaskEdit = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskEdit
            // 
            this.TaskEdit.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaskEdit.Location = new System.Drawing.Point(267, 296);
            this.TaskEdit.Name = "TaskEdit";
            this.TaskEdit.Size = new System.Drawing.Size(214, 57);
            this.TaskEdit.TabIndex = 0;
            this.TaskEdit.Text = "タスク編集";
            this.TaskEdit.UseVisualStyleBackColor = true;
            this.TaskEdit.Click += new System.EventHandler(this.TaskEditClick);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(135, 54);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "ログアウト";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.LogoutClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(235, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "ユーザー画面";
            // 
            // TaskRegist
            // 
            this.TaskRegist.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaskRegist.Location = new System.Drawing.Point(267, 191);
            this.TaskRegist.Name = "TaskRegist";
            this.TaskRegist.Size = new System.Drawing.Size(214, 57);
            this.TaskRegist.TabIndex = 6;
            this.TaskRegist.Text = "新規タスク登録";
            this.TaskRegist.UseVisualStyleBackColor = true;
            this.TaskRegist.Click += new System.EventHandler(this.TaskRegistClick);
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskRegist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.TaskEdit);
            this.Name = "Admin_menu";
            this.Text = "Admin_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TaskEdit;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TaskRegist;
    }
}