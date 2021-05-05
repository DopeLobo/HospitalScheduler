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
        BindingSource provider_copy;
        BindingSource clinic_copy;

        public MakeSchedule(BindingSource csvprovider, BindingSource csvclinic, DateTime start, DateTime end)
        {
            InitializeComponent();
            provider_copy = csvprovider;
            clinic_copy = csvclinic;
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
            int count = 0;
            foreach (DateTime dt in dateTimes)
            {

                for (int i = 0; i < 2; i++)
                {
                    Schedule sc = new Schedule();
                    sc.dt_value = dt;
                    sc.Date = dt.ToShortDateString();
                    if(i == 0)
                    {
                        sc.Shift = "AM";
                        scheduleBindingSource.Add(sc);
                        dataGridView1[0, count].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridView1[0, count].Value = dt.DayOfWeek.ToString();
                    }
                    else
                    { 
                        sc.Shift = "PM";
                        scheduleBindingSource.Add(sc);
                        dataGridView1[0, count].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        //dataGridView1[0, count].Value = dt.DayOfWeek.ToString();
                    }
                    if((int)dt.DayOfWeek == 6 || (int)dt.DayOfWeek == 0)
                    {
                        dataGridView1.Rows[count].DefaultCellStyle.BackColor = Color.Gray;
                    }
                    else
                    {
                        schedule_output.Add(sc);
                    }
                    count++;

                }
              
            }
            //scheduleBindingSource.DataSource = schedule_output;

            List<Provider> providers_info = new List<Provider>();
            List<Clinic> clinic_info = new List<Clinic>();
            foreach (Provider s in provider_copy.List)
            {
                providers_info.Add(s);
                DataGridTextBoxColumn new_column = new DataGridTextBoxColumn();
                new_column.HeaderText = s.Specialty +"/"+ s.ProviderName;
                dataGridView1.Columns.Add(new_column.HeaderText, new_column.HeaderText);
            }
            foreach (Clinic c in clinic_copy.List)
            {
                clinic_info.Add(c);
            }
            make_schedule(schedule_output, providers_info, clinic_info, dateTimes);
        }

        private List<string> getDaysOfProvider(Provider p)
        {
            List<string> listOfDays = new List<string>();
            if(string.Equals(p.Mon, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Monday");
            }
            if (string.Equals(p.Tue, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Tuesday");
            }
            if (string.Equals(p.Wed, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Wednesday");
            }
            if (string.Equals(p.Thu, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Thursday");
            }
            if (string.Equals(p.Fri, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Friday");
            }
            if (string.Equals(p.Sat, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Saturday");
            }
            if (string.Equals(p.Sun, "TRUE", StringComparison.CurrentCultureIgnoreCase))
            {
                listOfDays.Add("Sunday");
            }
            return listOfDays;
        }
        private void make_schedule(List<Schedule> schedule, List<Provider> providers, List<Clinic> clinics, DateTime[] dateTimes)
        {
            int row_count = 0;
            List<Provider> fixed_full = new List<Provider>();
            List<Provider> fixed_part = new List<Provider>();
            List<Provider> flexible_full = new List<Provider>();
            List<Provider> flexible_part = new List<Provider>();
            List<ClinicProgress> clinicProgresses = new List<ClinicProgress>();
            foreach (Clinic c in clinics)
            {
                ClinicProgress cp = new ClinicProgress();
                cp.clinic = c;
                cp.minAdult = 1;
                cp.minPed = 1;
                cp.AssignedAdult = 0;
                cp.AssignedPed = 0;
                clinicProgresses.Add(cp);
            }
            foreach (Provider p in providers)
            {
                if (p.ScheduleType == "Fixed" && p.Type.Contains("Full"))
                {
                    fixed_full.Add(p);
                }
                else if (p.ScheduleType == "Fixed" && p.Type.Contains("Part"))
                {
                    fixed_part.Add(p);
                }
                else if (p.ScheduleType == "Flexible" && p.Type.Contains("Full"))
                {
                    flexible_full.Add(p);
                }
                else if (p.ScheduleType == "Flexible" && p.Type.Contains("Part"))
                {
                    flexible_part.Add(p);
                }
            }
            foreach (DateTime dt in dateTimes)
            {
                int count = 0;
                foreach(Provider p in providers)
                {
                    List<string> listOfDays = getDaysOfProvider(p);
                    if (((int)dt.DayOfWeek == 6 || (int)dt.DayOfWeek == 0) || (p.ScheduleType == "Fixed" && !listOfDays.Contains(dt.DayOfWeek.ToString())))
                    {
                        dataGridView1[count+2, row_count].Value = "SDO";
                        dataGridView1[count + 2, row_count+1].Value = "SDO";
                    }
                    count++;
                }
                row_count = row_count+2;
            }
            row_count = 0;
            List<Provider> all_providers = fixed_full.Concat(fixed_part).Concat(flexible_part).Concat(flexible_full).ToList();
            foreach(DateTime dt in dateTimes)
            {
                foreach(ClinicProgress cp in clinicProgresses)
                {
                    foreach (Provider p in all_providers)
                    {
                        if ((dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count].Value) == "SDO" ||
                            (dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count].Value) != null)
                        {
                            continue;
                        }
                        if (cp.AssignedAdult >= cp.minAdult && cp.AssignedPed >= cp.minPed)
                        {
                            continue;
                        }
                        if (p.Specialty == "Adult")
                        {
                            if ( cp.AssignedAdult <= cp.minAdult || (p.PreferredLocation == cp.clinic.ClinicID && cp.AssignedAdult < cp.clinic.Adults))
                            {
                                cp.AssignedAdult++;
                                dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count].Value = cp.clinic.ClinicID;
                                dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count + 1].Value = cp.clinic.ClinicID;

                            }
                        }
                        else if (p.Specialty == "Peadiatric")
                        {
                            if ( cp.AssignedPed <= cp.minPed || (p.PreferredLocation == cp.clinic.ClinicID && cp.AssignedPed < cp.clinic.Pediatrics))
                            {
                                cp.AssignedPed++;
                                dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count].Value = cp.clinic.ClinicID;
                                dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count + 1].Value = cp.clinic.ClinicID;

                            }
                        }
                        else
                        {
                            if ((cp.AssignedPed <= cp.minPed || cp.AssignedAdult <= cp.minAdult) || (p.PreferredLocation == cp.clinic.ClinicID && (cp.AssignedPed < cp.clinic.Pediatrics || cp.AssignedAdult < cp.clinic.Adults)))
                            {
                                cp.AssignedAdult++;
                                cp.AssignedPed++;
                                dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count].Value = cp.clinic.ClinicID;
                                dataGridView1[dataGridView1.Columns[p.Specialty + "/" + p.ProviderName].Index, row_count + 1].Value = cp.clinic.ClinicID;

                            }
                        }

                    }
                    cp.AssignedAdult = 0;
                    cp.AssignedPed = 0;
                }
                row_count = row_count + 2;
            }
        }
    }
}
