using System;
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
    public partial class UpdAppForm : Form
    {
        public UpdAppForm()
        {
            InitializeComponent();
        }

        public HomeForm HomeUpdApp; //Connects to button that opens this page.
        public static Dictionary<string, string> UpdApp = new Dictionary<string, string>();

        public static bool UpdateApp(Dictionary<string, string> updApp)  //Updates information 
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logUpdate = $"UPDATE appointment" +
                               $" SET customerID = '{updApp["customerID"]}', type = '{updApp["type"]}', start = '{updApp["start"]}', end = '{updApp["end"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.LogTimeStamp()}'" +
                               $" WHERE appointmentID = '{updApp["appointmentID"]}'";
            MySqlCommand command = new MySqlCommand(logUpdate, s);
            int updatedApp = command.ExecuteNonQuery();

            if (updatedApp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdAppSearch_Click(object sender, EventArgs e) //Fills corresponding boxes with information when searching by Appointment ID
        {
            string appID = UpdAppID.Text;
            UpdApp = AppDatabase.GetAppInfo(appID);
            UpdAppCustID.Text = UpdApp["customerId"];
            UpdAppType.Text = UpdApp["type"];
        }

        public static bool AppointConflict(DateTime startTime, DateTime endTime) //This defines the function that prevents appointments from being created if the time conflicts with another already-set appointment.
        {
            foreach (var app in AppDatabase.GetAppointments().Values)
            {
                if (startTime < DateTime.Parse(app["end"].ToString()) &&
                    DateTime.Parse(app["start"].ToString()) < endTime)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool BusinessHourConflict(DateTime startTime, DateTime endTime) //This defines the function that prevents and appointment from being created outside of business hours.
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime openTime = DateTime.Today.AddHours(8);
            DateTime closeTime = DateTime.Today.AddHours(17);

            if (startTime.TimeOfDay > openTime.TimeOfDay && startTime.TimeOfDay < closeTime.TimeOfDay &&
                endTime.TimeOfDay > openTime.TimeOfDay && endTime.TimeOfDay < closeTime.TimeOfDay)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UpdAppSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> UpdSave = new Dictionary<string, string>();
            UpdSave.Add("customerId", UpdAppCustID.Text);
            UpdSave.Add("type", UpdAppType.Text);
            UpdSave.Add("start", UpdAppStart.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
            UpdSave.Add("end", UpdAppEnd.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));

            string timestamp = AppDatabase.LogTimeStamp();
            int userID = AppDatabase.GetUserID();
            string username = AppDatabase.GetUserName();
            DateTime startTime = UpdAppStart.Value.ToUniversalTime();
            DateTime endTime = UpdAppEnd.Value.ToUniversalTime();

            if (BusinessHourConflict(startTime, endTime))
            {
                HomeUpdApp.HomeCalUpdate();
                MessageBox.Show("Appointment successfully updated.", "Success");
                Close();
                MessageBox.Show(
                    "This appointment falls outside of business hours, please choose a different time and try again.",
                    "Error");
            }
            else if (AppointConflict(startTime, endTime))
            {
                MessageBox.Show(
                    "There is already an appointment that falls within the time you're choosing, please choose a different time and try again.",
                    "Error");
            }
            else
            {
                Dictionary<string, string> saveMods = new Dictionary<string, string>();
                saveMods.Add("customerId", UpdAppCustID.Text);
                saveMods.Add("type", UpdAppType.Text);
                saveMods.Add("start", UpdAppStart.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
                saveMods.Add("end", UpdAppEnd.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));

                if (UpdateApp(UpdSave))
                {
                    HomeUpdApp.HomeCalUpdate();
                    MessageBox.Show("Appointment successfully updated.", "Success");
                    Close();
                }

            }
        }

        private void UpdAppCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
