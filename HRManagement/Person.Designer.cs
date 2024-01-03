namespace HRManagement
{
    partial class Person
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
            this.components = new System.ComponentModel.Container();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataController1 = new HRManagement.DataController();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(HRManagement.Models.Person);
            // 
            // dataController1
            // 
            this.dataController1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataController1.Location = new System.Drawing.Point(0, 0);
            this.dataController1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataController1.Name = "dataController1";
            this.dataController1.Size = new System.Drawing.Size(1190, 637);
            this.dataController1.TabIndex = 0;
            this.dataController1.Load += new System.EventHandler(this.dataController1_Load);
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 637);
            this.Controls.Add(this.dataController1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Person";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personBindingSource;
        private DataController dataController1;
    }
}

