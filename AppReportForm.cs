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

namespace C969_Scheduling_Application
{
    public partial class AppReportForm : Form
    {
        public AppReportForm()
        {
            InitializeComponent();
            AppReport.DataSource = AppReports();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public struct AppointReport
        {
            public string appMonth;
            public string appType;
            public int numApps;
        }

        public static Array AppReports()
        {
            List<AppointReport> appList = new List<AppointReport>();
            List<Hashtable> appType = new List<Hashtable>();
            SortedList appMonths = new SortedList();
            appMonths.Add(1, "January");
            appMonths.Add(2, "February");
            appMonths.Add(3, "March");
            appMonths.Add(4, "April");
            appMonths.Add(5, "May");
            appMonths.Add(6, "June");
            appMonths.Add(7, "July");
            appMonths.Add(8, "August");
            appMonths.Add(9, "September");
            appMonths.Add(10, "October");
            appMonths.Add(11, "November");
            appMonths.Add(12, "December");

            foreach (var appointment in AppDatabase.GetAppointments().Values)
            {
                int month = DateTime.Parse(appointment["start"].ToString()).Month;
                bool moreThanOne = false;

                foreach (AppointReport app in appList)
                {
                    if (app.appMonth == appMonths[month].ToString() && app.appType == appointment["type"].ToString())
                    {
                        moreThanOne = true;
                    }
                }

                if (!moreThanOne)
                {
                    AppointReport appReport = new AppointReport();
                    appReport.appMonth = appMonths[month].ToString();
                    appReport.appType = appointment["type"].ToString();

                    //Lambda function that counts distinct types of appointments within the month the report is on and lists them, removing the need to create a unique function as this would only be used for this function.

                    appReport.numApps = AppDatabase.GetAppointments().Where(i =>
                        i.Value["type"].ToString() == appointment["type"].ToString() &&
                        DateTime.Parse(i.Value["start"].ToString()).Month == month).Count();

                    appList.Add(appReport);
                }
            }

            var appArray = from row in appList
                           select new
                           {
                               Month = row.appMonth,
                               Type = row.appType,
                               Number = row.numApps
                           };

            return appArray.ToArray();
        }

        private void AppReportExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
