
namespace WindowsFormsApp1
{
    partial class Task_List
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
            this.DetaView = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetaView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetaView
            // 
            this.DetaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetaView.Location = new System.Drawing.Point(-1, -4);
            this.DetaView.Name = "DetaView";
            this.DetaView.RowHeadersWidth = 51;
            this.DetaView.RowTemplate.Height = 24;
            this.DetaView.Size = new System.Drawing.Size(807, 463);
            this.DetaView.TabIndex = 0;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(12, 396);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(103, 42);
            this.Return.TabIndex = 1;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Task_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.DetaView);
            this.Name = "Task_List";
            this.Text = "Task_List";
            this.Load += new System.EventHandler(this.Task_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetaView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DetaView;
        private System.Windows.Forms.Button Return;
    }
}