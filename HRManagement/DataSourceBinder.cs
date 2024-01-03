using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement
{
    internal class DataSourceBinder<T> where T : class, new()
    {
        public DataSourceBinder(DataController controller, DbSet<T> source)
        {
            this.dataController = controller;
            this.Source = source;
            dataController.dataGrid.CellClick += DataGrid_CellClick;
            dataController.Load += DataController_Load;
            dataController.saveToolStripButton.Click += SaveToolStripButton_Click;
            dataController.cutToolStripButton.Click += CutToolStripButton_Click;
            dataController.newToolStripButton.Click += NewToolStripButton_Click;
        }

        void setDataSource(IEnumerable<T> list)
        {
            dataController.dataGrid.DataSource = null;

            if (list.Count() > 0)
            {
                dataController.dataGrid.DataSource = list;
            }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public event EventHandler OnSave;
        DataController dataController;
        DbSet<T> Source { get; set; }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            var item = new T();
            Source.Add(item);
            var list = (dataController.dataGrid.DataSource as List<T>)??new List<T>();
            list.Add(item);
            setDataSource(list);
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            List<T> deleteList = new List<T>();
            var source = (dataController.dataGrid.DataSource as List<T>);
            foreach (DataGridViewRow row in dataController.dataGrid.SelectedRows)
            {
                deleteList.Add(source[row.Index]);
            }
            deleteList.ForEach(delete => source.Remove(delete));
            setDataSource(source);
            Source.RemoveRange(deleteList);
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(this, EventArgs.Empty);
        }

        private void DataController_Load(object sender, EventArgs e)
        {
           setDataSource(Source.ToList());
        }
    }
}
