
namespace WindowsFormsApp1
{
    partial class Task_Regist
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.TextBox();
            this.Startday = new System.Windows.Forms.TextBox();
            this.Due_date = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.Importance = new System.Windows.Forms.ComboBox();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(249, 58);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(327, 43);
            this.label.TabIndex = 0;
            this.label.Text = "新規タスク登録";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "タスク名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(126, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "担当者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(126, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "重要度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(382, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "開始日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(392, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "期日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(549, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "備考";
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(87, 208);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(160, 22);
            this.Manager.TabIndex = 9;
            // 
            // Startday
            // 
            this.Startday.Location = new System.Drawing.Point(340, 208);
            this.Startday.Name = "Startday";
            this.Startday.Size = new System.Drawing.Size(146, 22);
            this.Startday.TabIndex = 10;
            // 
            // Due_date
            // 
            this.Due_date.Location = new System.Drawing.Point(340, 339);
            this.Due_date.Name = "Due_date";
            this.Due_date.Size = new System.Drawing.Size(146, 22);
            this.Due_date.TabIndex = 11;
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(544, 161);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(232, 214);
            this.Note.TabIndex = 12;
            // 
            // Importance
            // 
            this.Importance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Importance.FormattingEnabled = true;
            this.Importance.Location = new System.Drawing.Point(87, 339);
            this.Importance.Name = "Importance";
            this.Importance.Size = new System.Drawing.Size(160, 23);
            this.Importance.TabIndex = 14;
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaskName.Location = new System.Drawing.Point(45, 75);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(150, 27);
            this.TaskName.TabIndex = 15;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegistrationButton.Location = new System.Drawing.Point(688, 399);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(100, 39);
            this.RegistrationButton.TabIndex = 17;
            this.RegistrationButton.Text = "登録";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButtonClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReturnButton.Location = new System.Drawing.Point(12, 399);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(100, 39);
            this.ReturnButton.TabIndex = 18;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Task_Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.Importance);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Due_date);
            this.Controls.Add(this.Startday);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "Task_Regist";
            this.Text = "Task_Regist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Manager;
        private System.Windows.Forms.TextBox Startday;
        private System.Windows.Forms.TextBox Due_date;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.ComboBox Importance;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button button1;
    }
}