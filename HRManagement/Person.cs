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
    public partial class Person : Form
    {
        
        DataSourceBinder<Models.Person> dataSourceBinder;
        public Person()
        {
            InitializeComponent();
            dataSourceBinder = new DataSourceBinder<Models.Person>(this.dataController1, DbConnector.DBEntities.Person);
            dataController1.dataGrid.Columns.Add(new DataGridViewColumn()
            {
                Name = "Name",
                DataPropertyName = "FirstName",
                CellTemplate = new DataGridViewTextBoxCell()
            }); 
            dataController1.dataGrid.Columns.Add(new DataGridViewColumn()
            {
                Name = "Last Name",
                DataPropertyName = "LastName",
                CellTemplate = new DataGridViewTextBoxCell()
            }); 
            dataController1.dataGrid.Columns.Add(new DataGridViewColumn()
            {
                Name = "Phone",
                DataPropertyName = "PhoneNumber",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            dataController1.dataGrid.Columns.Add(new DataGridViewColumn()
            {
                Name = "Email",
                DataPropertyName = "Email",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            var address = new DataGridViewComboBoxCell();
            address.DataSource=DbConnector.DBEntities.Person.ToList();
            address.DisplayMember = "FirstName";
            address.ValueMember = "PersonID";
            dataController1.dataGrid.Columns.Add(new DataGridViewColumn()
            {
                Name = "Address",
                DataPropertyName = "PersonAddress",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            var editBtn = new DataGridViewButtonCell()
            {
                Value = "Edit"
                
            };

            dataController1.dataGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Edit",
                HeaderText = "EDIT",
                CellTemplate = editBtn,
                UseColumnTextForButtonValue=true,
                Text="Edit",
            }); dataController1.dataGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Delete",
                HeaderText = "DELETE",
                UseColumnTextForButtonValue = true,
                Text="Delete",
                CellTemplate = editBtn,
            });

            dataController1.dataGrid.CellContentClick += DataGrid_CellContentClick;
            dataSourceBinder.OnSave += DataSourceBinder_OnSave;
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataController1.dataGrid.Columns[e.ColumnIndex].Name == "Edit")
                new PersonEditForm((dataController1.dataGrid.DataSource as List<Models.Person>)[e.RowIndex]).Show();
        }

        private void DataSourceBinder_OnSave(object sender, EventArgs e)
        {
            DbConnector.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataController1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
