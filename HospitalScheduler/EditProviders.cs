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
                    providerBindingSource.DataSource = csv.GetRecords<Provider>().ToList();
                    sr.Close();
                }
            }
        }

        private void EditProviders_Load(object sender, EventArgs e)
        {
            providerBindingSource.AllowNew = true;
            providerBindingSource.DataSource = new List<Provider>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewComboBoxCell l_objGridDropbox = new DataGridViewComboBoxCell();
            if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("preferences"))
            {
                dataGridView1[e.ColumnIndex, e.RowIndex] = PreferencesList();
            }*/
        }
        private DataGridViewComboBoxCell PreferencesList()
        {
            DataGridViewComboBoxCell combolist = new DataGridViewComboBoxCell();
            string[] itemlist = { "Weekend", "Days" };
            combolist.Items.AddRange(itemlist);

            return combolist;
        }
        private DataGridViewComboBoxCell Full_Part_Time()
        {
            DataGridViewComboBoxCell combolist = new DataGridViewComboBoxCell();
            string[] itemlist = { "Full-Time", "Part-Time" };
            combolist.Items.AddRange(itemlist);

            return combolist;
        }
        private DataGridViewComboBoxCell PreferredLocation()
        {
            DataGridViewComboBoxCell combolist = new DataGridViewComboBoxCell();
            string[] itemlist = { "CHCF", "THS", "PPHC"};
            combolist.Items.AddRange(itemlist);

            return combolist;
        }
        private DataGridViewComboBoxCell SpecialtyList()
        {
            DataGridViewComboBoxCell combolist = new DataGridViewComboBoxCell();
            string[] itemlist = { "Adult", "Peadiatric", "Family" };
            combolist.Items.AddRange(itemlist);

            return combolist;
        }
        private DataGridViewComboBoxCell ScheduleTypeList()
        {
            DataGridViewComboBoxCell combolist = new DataGridViewComboBoxCell();
            string[] itemlist = { "Fixed", "Flexible" };
            combolist.Items.AddRange(itemlist);

            return combolist;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].Name.Contains("preferred"))
                {
                    dataGridView1[i, dataGridView1.RowCount - 1] = PreferredLocation();
                }
                if (dataGridView1.Columns[i].Name.Contains("type"))
                {
                    dataGridView1[i, dataGridView1.RowCount - 1] = Full_Part_Time();
                }
                if (dataGridView1.Columns[i].Name.Contains("specialty"))
                {
                    dataGridView1[i, dataGridView1.RowCount - 1] = SpecialtyList();
                }
                if (dataGridView1.Columns[i].Name.Contains("schedule"))
                {
                    dataGridView1[i, dataGridView1.RowCount - 1] = ScheduleTypeList();
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell l_objGridDropbox = new DataGridViewComboBoxCell();
            //Check deleted rows
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    providerBindingSource.RemoveCurrent();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("preferred"))
            {
                dataGridView1[e.ColumnIndex, e.RowIndex] = PreferredLocation();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("type"))
            {
                dataGridView1[e.ColumnIndex, e.RowIndex] = Full_Part_Time();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("specialty"))
            {
                dataGridView1[e.ColumnIndex, e.RowIndex] = SpecialtyList();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("schedule"))
            {
                dataGridView1[e.ColumnIndex, e.RowIndex] = ScheduleTypeList();
            }
        }
    }
}
