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
    public partial class DelAppForm : Form
    {
        public DelAppForm()
        {
            InitializeComponent();
        }

        public HomeForm HomeDelApp; //Connects to the corresponding button on the home page
        public static Dictionary<string, string> appInfo = new Dictionary<string, string>();

        private void DelAppSearch_Click(object sender, EventArgs e)
        {
            string appID = DelAppID.Text;
            appInfo = AppDatabase.GetAppInfo(appID);
            DelAppType.Text = appInfo["type"];
            DelAppCustID.Text = appInfo["customerId"];
        }

        private void DelAppDel_Click(object sender, EventArgs e)
        {
            DialogResult delAppConfirm = MessageBox.Show("Are you sure you want to delete this appointment?",
                "Confirmation", MessageBoxButtons.YesNo);
            if (delAppConfirm == DialogResult.Yes)
            {
                if (DelApp())
                {
                    HomeDelApp.HomeCalUpdate();
                }
                else
                {
                    MessageBox.Show($"The appointment {appInfo["type"]} could not be deleted.", "Error");
                }
            }
            Close();
        }

        public static bool DelApp() //Function for removing an appointment from the database
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logDeletion = $"DELETE FROM appointment" +
                                 $" WHERE appointmentId = '{appInfo["appointmentId"]}'";
            MySqlCommand command = new MySqlCommand(logDeletion, s);
            int deletedApp = command.ExecuteNonQuery();
            s.Close();

            if (deletedApp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DelAppCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
