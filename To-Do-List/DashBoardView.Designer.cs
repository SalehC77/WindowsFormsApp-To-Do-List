namespace To_Do_List
{
    partial class DashBoardView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_DashBorad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AcceptStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_DashBorad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1629, 565);
            this.dataGridView1.TabIndex = 0;
           
            // 
            // panel_DashBorad
            // 
            this.panel_DashBorad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.panel_DashBorad.Controls.Add(this.label2);
            this.panel_DashBorad.Controls.Add(this.label1);
            this.panel_DashBorad.Location = new System.Drawing.Point(1, 1);
            this.panel_DashBorad.Name = "panel_DashBorad";
            this.panel_DashBorad.Size = new System.Drawing.Size(1943, 189);
            this.panel_DashBorad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Overview of Center Acativities And User Statistic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DashBoard";
            // 
            // btn_AcceptStudent
            // 
            this.btn_AcceptStudent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_AcceptStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.btn_AcceptStudent.Location = new System.Drawing.Point(791, 815);
            this.btn_AcceptStudent.Name = "btn_AcceptStudent";
            this.btn_AcceptStudent.Size = new System.Drawing.Size(259, 75);
            this.btn_AcceptStudent.TabIndex = 3;
            this.btn_AcceptStudent.Text = "Accept Student          >";
            this.btn_AcceptStudent.UseVisualStyleBackColor = true;
            this.btn_AcceptStudent.Click += new System.EventHandler(this.btn_AcceptStudent_Click);
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 915);
            this.Controls.Add(this.btn_AcceptStudent);
            this.Controls.Add(this.panel_DashBorad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DashBoardView";
            this.Text = "DashBoardView";
            this.Load += new System.EventHandler(this.DashBoardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_DashBorad.ResumeLayout(false);
            this.panel_DashBorad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_DashBorad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AcceptStudent;
    }
}