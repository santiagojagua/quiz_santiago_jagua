﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class Report : Form
    {
        public Report(string pRecibir)
        {
            InitializeComponent();
            label1.Text = pRecibir;
        }
    }
}
