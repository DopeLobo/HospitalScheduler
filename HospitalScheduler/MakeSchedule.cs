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
    public partial class MakeSchedule : Form
    {
        DateTime start_date;
        DateTime end_date;
        public MakeSchedule(BindingSource csvprovider, BindingSource csvclinic, DateTime start, DateTime end)
        {
            InitializeComponent();
            providerBindingSource.DataSource = csvprovider;
            clinicBindingSource.DataSource = csvclinic;
            start_date = start;
            end_date = end;
    
        }
        public DateTime[] GetDatesBetween(List<Schedule> sc, DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                allDates.Add(date);
            return allDates.ToArray();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            scheduleBindingSource.Add(new Schedule() { Date = "Hello" });
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
                        writer.WriteHeader(typeof(Schedule));
                        writer.NextRecord();
                        foreach (Schedule s in scheduleBindingSource.DataSource as List<Schedule>)
                        {
                            writer.WriteRecord(s);
                            writer.NextRecord();
                        }
                    }
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MakeSchedule_Load(object sender, EventArgs e)
        {
            scheduleBindingSource.AllowNew = true;
            scheduleBindingSource.DataSource = new List<Schedule>();
            List<Schedule> schedule_output = new List<Schedule>();
            DateTime[] dateTimes = GetDatesBetween(schedule_output, start_date, end_date);
            foreach (DateTime dt in dateTimes)
            {
                for (int i = 0; i < 2; i++)
                {
                    Schedule sc = new Schedule();
                    sc.Date = dt.Date.ToString();
                    if(i == 0)
                    {
                        sc.Shift = "AM";
                    }
                    else { sc.Shift = "PM"; }
                    schedule_output.Add(sc);
                }
              
            }
            scheduleBindingSource.DataSource = schedule_output;
        }
    }
}
