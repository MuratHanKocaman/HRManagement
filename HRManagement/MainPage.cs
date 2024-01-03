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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resume resume = new Resume();
            resume.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Person());
        }

        private void OpenForm(Form form)
        {

            form.MdiParent = this;
            form.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Models.Person p= new Models.Person();
            DbConnector.DBEntities.Person.Add(p);
            OpenForm(new PersonEditForm(p));
        }
    }
}
