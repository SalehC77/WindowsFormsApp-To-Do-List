namespace To_Do_List
{
    partial class ParentForm
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
            this.header = new System.Windows.Forms.Panel();
            this.logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(241, 242, 247);
            this.header.Controls.Add(this.logo_PictureBox);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 44);
            this.header.TabIndex = 1;
            // 
            // logo_PictureBox
            // 
            this.logo_PictureBox.Image = global::To_Do_List.Properties.Resources.Logo;
            this.logo_PictureBox.Location = new System.Drawing.Point(16, 0);
            this.logo_PictureBox.Name = "logo_PictureBox";
            this.logo_PictureBox.Size = new System.Drawing.Size(213, 45);
            this.logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo_PictureBox.TabIndex = 0;
            this.logo_PictureBox.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.header);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox logo_PictureBox;
    }
}