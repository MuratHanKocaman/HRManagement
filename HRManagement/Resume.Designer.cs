namespace HRManagement
{
    partial class Resume
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
            this.dataController1 = new HRManagement.DataController();
            this.SuspendLayout();
            // 
            // dataController1
            // 
            this.dataController1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataController1.Location = new System.Drawing.Point(0, 0);
            this.dataController1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataController1.Name = "dataController1";
            this.dataController1.Size = new System.Drawing.Size(1491, 682);
            this.dataController1.TabIndex = 1;
            // 
            // Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 682);
            this.Controls.Add(this.dataController1);
            this.Name = "Resume";
            this.Text = "Resume";
            this.Load += new System.EventHandler(this.Resume_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DataController dataController1;
    }
}