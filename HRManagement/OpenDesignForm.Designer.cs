namespace HRManagement
{
    partial class OpenDesignForm
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
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.header.ForeColor = System.Drawing.SystemColors.Window;
            this.header.Location = new System.Drawing.Point(161, 22);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(906, 124);
            this.header.TabIndex = 1;
            this.header.Text = "Welcome to HRM";
            // 
            // OpenDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HRManagement.Properties.Resources.HRM;
            this.ClientSize = new System.Drawing.Size(1254, 553);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenDesignForm";
            this.Text = "OpenDesignForm";
            this.Load += new System.EventHandler(this.OpenDesignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
    }
}