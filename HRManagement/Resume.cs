using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement
{
    public partial class Resume : Form
    {
        DataSourceBinder<Models.Resumes> dataSourceBinder;
        public Resume()
        {
            InitializeComponent();
            dataController1.dataGrid.Columns.Add(new DataGridViewColumn()
            {
                Name = "Name",
                DataPropertyName = "ResumeID",
                CellTemplate= new DataGridViewTextBoxCell()
                {
                    ReadOnly = true,
                }
            });
           dataSourceBinder = new DataSourceBinder<Models.Resumes>(this.dataController1, DbConnector.DBEntities.Resumes); 
        }

        private void Resume_Load(object sender, EventArgs e)
        {

        }
    }
}
