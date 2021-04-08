using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalScheduler
{
    public partial class ImportFilesDialog : Form
    {
        BindingSource csvprovider = new BindingSource();
        BindingSource csvclinic = new BindingSource();
        public ImportFilesDialog()
        {
            InitializeComponent();
        }

        private void btnImportProviders_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
                    {
                        csv.Read();
                        csv.ReadHeader();
                        string[] headerRow = csv.HeaderRecord;
                        if (headerRow[0] != "ProviderID")
                        {
                            this.labelProviderStatus.BackColor = Color.LightPink;
                            this.labelProviderStatus.Text = "Incompatible File";
                        }
                        else
                        {
                            this.labelProviderStatus.BackColor = Color.LightGreen;
                            this.labelProviderStatus.Text = "Uploaded File";
                            csvprovider.DataSource = csv.GetRecords<Provider>();
                            if (this.labelClinicStatus.Text == "Uploaded File")
                            {
                                btnGenSchedule.Visible = true;
                            }

                        }
                    }
                    sr.Close();
                    //providerBindingSource.DataSource = csv.GetRecords<Provider>();  //Commented because we don't have a bindingsource in this Dialog.
                }
            }
        }

        private void btnImportClinics_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
                    {
                        csv.Read();
                        csv.ReadHeader();
                        string[] headerRow = csv.HeaderRecord;
                        if (headerRow[0] != "ClinicID")
                        {
                            this.labelClinicStatus.BackColor = Color.LightPink;
                            this.labelClinicStatus.Text = "Incompatible File";
                        }
                        else
                        {
                            this.labelClinicStatus.BackColor = Color.LightGreen;
                            this.labelClinicStatus.Text = "Uploaded File";
                            csvclinic.DataSource = csv.GetRecords<Clinic>();
                            if (this.labelProviderStatus.Text == "Uploaded File")
                            {
                                btnGenSchedule.Visible = true;
                            }

                        }
                    }
                    sr.Close();
                    //providerBindingSource.DataSource = csv.GetRecords<Provider>();  //Commented because we don't have a bindingsource in this Dialog.
                }
            }
        }

        private void btnGenSchedule_Click(object sender, EventArgs e)
        {
            MakeSchedule ms = new MakeSchedule(csvprovider, csvclinic);
            ms.Show();
            this.Close();
        }
    }
}
