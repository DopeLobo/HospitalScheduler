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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEditProviders_Click(object sender, EventArgs e)
        {
            EditProviders ep = new EditProviders();
            ep.Show();
        }

        private void btnMakeSchedule_Click(object sender, EventArgs e)
        {
            ImportFilesDialog ifd = new ImportFilesDialog();
            ifd.Show();
        }

        private void btnEditClinics_Click(object sender, EventArgs e)
        {
            EditClinics ec = new EditClinics();
            ec.Show();
        }
    }
}
