
namespace WindowsFormsApp1
{
    partial class Task_Edit
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
            this.Update_Button = new System.Windows.Forms.Button();
            this.DateView = new System.Windows.Forms.DataGridView();
            this.Update_Text = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DateView)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update_Button.Location = new System.Drawing.Point(473, 369);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(177, 69);
            this.Update_Button.TabIndex = 0;
            this.Update_Button.Text = "変更";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // DateView
            // 
            this.DateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateView.Location = new System.Drawing.Point(29, 12);
            this.DateView.Name = "DateView";
            this.DateView.RowHeadersWidth = 51;
            this.DateView.RowTemplate.Height = 24;
            this.DateView.Size = new System.Drawing.Size(745, 326);
            this.DateView.TabIndex = 1;
            this.DateView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateView_CellContentClick);
            // 
            // Update_Text
            // 
            this.Update_Text.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update_Text.Location = new System.Drawing.Point(224, 380);
            this.Update_Text.Name = "Update_Text";
            this.Update_Text.Size = new System.Drawing.Size(177, 27);
            this.Update_Text.TabIndex = 2;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(29, 369);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(96, 49);
            this.Return.TabIndex = 3;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(72, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "更新対象のセルをクリックしてからtextboxに変更後のtextを入力";
            // 
            // Task_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Update_Text);
            this.Controls.Add(this.DateView);
            this.Controls.Add(this.Update_Button);
            this.Name = "Task_Edit";
            this.Text = "Task_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.DateView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.DataGridView DateView;
        private System.Windows.Forms.TextBox Update_Text;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
    }
}