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
    public partial class PersonEditForm : Form
    {
        Models.Person person;
        public PersonEditForm(Models.Person person)
        {
            InitializeComponent();
            this.person = person;
            this.textBox1.DataBindings.Add("Text",
                                this.person,
                                "FirstName",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbConnector.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
