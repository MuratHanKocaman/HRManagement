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
    public partial class OpenDesignForm : Form
    {
        public OpenDesignForm()
        {
            InitializeComponent();
        }

        private void OpenDesignForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MainPage p = new MainPage();
            p.FormClosed += P_FormClosed;
            p.Show();
            this.Hide();
            (sender as Timer).Stop();
        }

        private void P_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
