﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalScheduler
{
    public partial class MakeSchedule : Form
    {
        public MakeSchedule(BindingSource csvprovider, BindingSource csvclinic)
        {
            InitializeComponent();
            providerBindingSource.DataSource = csvprovider;
            clinicBindingSource.DataSource = csvclinic;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
