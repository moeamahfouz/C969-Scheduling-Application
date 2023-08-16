using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969_Scheduling_Application
{
    public partial class HomeForm : Form
    {

        public LoginForm loginForm;
        public HomeForm()
        {
            InitializeComponent();
            UpcomingApps(HomeCalendar);
            HomeRadioMonth.Checked = true;
            HomeCalendar.DataSource = HomeAppCalendar(HomeRadioWeek.Checked); //These two lines display month view by default, populates week view if week radio is clicked
        }

        public static void UpcomingApps(DataGridView homeCalendar) //Displays notification showing user their upcoming appointments
        {
            foreach (DataGridViewRow row in homeCalendar.Rows)
            {
                DateTime currentTime = DateTime.UtcNow;
                DateTime startTime = DateTime.Parse(row.Cells[2].Value.ToString()).ToUniversalTime();
                TimeSpan timeUntilApp = currentTime - startTime;

                if (timeUntilApp.TotalMinutes >= -15 && timeUntilApp.TotalMinutes < 1)
                {
                    MessageBox.Show(
                        $"You have an upcoming appointment with {row.Cells[4].Value} at {row.Cells[2].Value}");
                }
            }
        }

        public static Array HomeAppCalendar(bool week) //Populates the dashboard calendar with upcoming appointments and appointment details.
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string query =
                $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{AppDatabase.GetUserID()}'";
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();

            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            while (reader.Read())
            {
                Hashtable apps = new Hashtable();
                apps.Add("customerId", reader[0]);
                apps.Add("type", reader[1]);
                apps.Add("start", reader[2]);
                apps.Add("end", reader[3]);
                apps.Add("userId", reader[5]);

                appointments.Add(Convert.ToInt32(reader[4]), apps);
            }
            reader.Close();

            foreach (var app in appointments.Values)
            {
                query = $"SELECT userName FROM user WHERE userId = '{app["userId"]}'";
                command = new MySqlCommand(query, s);
                reader = command.ExecuteReader();
                reader.Read();
                app.Add("userName", reader[0]);
                reader.Close();
            }

            foreach (var app in appointments.Values)
            {
                query = $"SELECT customerName FROM customer WHERE customerId = '{app["customerId"]}'";
                command = new MySqlCommand(query, s);
                reader = command.ExecuteReader();
                reader.Read();
                app.Add("customerName", reader[0]);
                reader.Close();
            }

            Dictionary<int, Hashtable> addedApps = new Dictionary<int, Hashtable>();

            foreach (var app in appointments)
            {
                DateTime starTime = DateTime.Parse(app.Value["start"].ToString());
                DateTime endTime = DateTime.Parse(app.Value["end"].ToString());
                DateTime currDateTime = DateTime.UtcNow;

                if (week)
                {
                    DateTime sunday = currDateTime.AddDays(-(int)currDateTime.DayOfWeek);
                    DateTime saturday = currDateTime.AddDays(-(int)currDateTime.DayOfWeek + (int)DayOfWeek.Saturday);

                    if (starTime >= sunday && endTime < saturday)
                    {
                        addedApps.Add(app.Key, app.Value);
                    }
                }

                else
                {
                    DateTime firstOfMonth = new DateTime(currDateTime.Year, currDateTime.Month, 1);
                    DateTime lastOfMonth = firstOfMonth.AddMonths(1);

                    if (starTime >= firstOfMonth && endTime < lastOfMonth)
                    {
                        addedApps.Add(app.Key, app.Value);
                    }
                }
            }

            AppDatabase.SetAppointments(appointments);

            var appList = from row in addedApps
                          select new
                          {
                              ID = row.Key,
                              Type = row.Value["type"],
                              Start = AppDatabase.TimezoneConversion(row.Value["start"].ToString()),
                              End = AppDatabase.TimezoneConversion(row.Value["end"].ToString()),
                              Customer = row.Value["customerName"]
                          };

            s.Close();

            return appList.ToArray();
        }

        public void HomeCalUpdate()
        {
            HomeCalendar.DataSource = HomeAppCalendar(HomeRadioWeek.Checked);
        }

        private void HomeRadioWeek_CheckedChanged(object sender, EventArgs e)
        {
            HomeCalUpdate();
        }

        private void HomeRadioMonth_CheckedChanged(object sender, EventArgs e)
        {
            HomeCalUpdate();
        }

        private void HomeAddCust_Click(object sender, EventArgs e) //Opens New Customer page upon clicking New Customer
        {
            NewCustForm newCust = new NewCustForm();
            newCust.Show();
        }

        private void HomeUpdCust_Click(object sender, EventArgs e) //Opens Update Customer Page upon clicking Update Customer
        {
            UpdCustForm updCust = new UpdCustForm();
            updCust.Show();
        }

        private void HomeDelCust_Click(object sender, EventArgs e) //Opens Delete Customer Page upon clicking Delete Customer
        {
            DelCustForm delCust = new DelCustForm();
            delCust.Show();
        }

        private void HomeNewApp_Click(object sender, EventArgs e) //Opens New Appointment Page upon clicking New Appointment
        {
            NewAppForm newApp = new NewAppForm();
            newApp.HomeNewApp = this;
            newApp.Show();
        }

        private void HomeUpdApp_Click(object sender, EventArgs e) //Opens Update Appointment Page upon clicking Update Appointment
        {
            UpdAppForm updApp = new UpdAppForm();
            updApp.HomeUpdApp = this;
            updApp.Show();
        }

        private void HomeDelApp_Click(object sender, EventArgs e) //Opens Delete Appointment Page upon clicking Delete Appointment
        {
            DelAppForm delApp = new DelAppForm();
            delApp.HomeDelApp = this;
            delApp.Show();
        }

        private void HomeAppReport_Click(object sender, EventArgs e) //Opens Appointment Report page upon clicking Appointment Reports
        {
            AppReportForm appReport = new AppReportForm();
            appReport.Show();
        }

        private void HomeConsReport_Click(object sender, EventArgs e) //Opens Consultant Report page upon clicking Consultant Reports
        {
           ConsReportForm consReport = new ConsReportForm();
            consReport.Show();
        }

        private void HomeCustReport_Click(object sender, EventArgs e) //Opens Customer Report page upon clicking Customer Reports
        {
            CustReportForm custReport = new CustReportForm();
            custReport.Show();
        }

        private void HomeExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
