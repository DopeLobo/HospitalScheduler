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
    public partial class EditProviders : Form
    {
        public EditProviders()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };
                    using (var sw = new StreamWriter(sfd.FileName))

                    using (var writer = new CsvWriter(sw, CultureInfo.InvariantCulture))
                    {
                        writer.WriteHeader(typeof(Provider));
                        writer.NextRecord();
                        foreach (Provider s in providerBindingSource.DataSource as List<Provider>)
                        {
                            writer.WriteRecord(s);
                            writer.NextRecord();
                        }
                    }
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
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
                    var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                    providerBindingSource.DataSource = csv.GetRecords<Provider>();
                }
            }
        }

        private void EditProviders_Load(object sender, EventArgs e)
        {
            providerBindingSource.DataSource = new List<Provider>();
        }
    }
}
