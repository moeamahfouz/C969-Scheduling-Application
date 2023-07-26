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
    public partial class ConsReportForm : Form
    {
        public ConsReportForm()
        {
            InitializeComponent();
            ConsReport.DataSource = ConsultantReport();
        }

        public static Array ConsultantReport()
        {
            Dictionary<int, Hashtable> ConsultantReportStructure = AppDatabase.GetAppointments();

            var appList = from row in ConsultantReportStructure
                          select new
                          {
                              userName = row.Value["userName"],
                              appType = row.Value["type"],
                              appStart = AppDatabase.TimezoneConversion(row.Value["start"].ToString()),
                              appEnd = AppDatabase.TimezoneConversion(row.Value["end"].ToString()),
                              cust = row.Value["customerName"]
                          };

            return appList.ToArray();
        }

    }
}
