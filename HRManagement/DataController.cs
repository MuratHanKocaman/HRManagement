﻿using System;
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
    public partial class DataController : UserControl
    {
        public DataController()
        {
            InitializeComponent();
            dataGrid.AutoGenerateColumns = false;
        }
    }
}
